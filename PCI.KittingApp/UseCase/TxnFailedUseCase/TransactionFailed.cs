using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.Entity.TransactionType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.UseCase
{
    public class TransactionFailed
    {
        private Repository.SQLite.TransactionFailed _transactionFailedRepository;
        private OpcenterSaveData _opcenterSaveData;
        private OpcenterCheckData _opcenterCheckData;
        public TransactionFailed(Repository.SQLite.TransactionFailed transactionFailedRepository, OpcenterSaveData opcenterSaveData, OpcenterCheckData opcenterCheckData)
        {
            _transactionFailedRepository = transactionFailedRepository;
            _opcenterSaveData = opcenterSaveData;
            _opcenterCheckData = opcenterCheckData;
        }

        public List<Entity.TransactionFailed> GetAll()
        {
            return _transactionFailedRepository.GetAll();
        }

        private void ShowMessageAlreadyExists()
        {
            ZIAlertBox.Warning("Data Already Exists!", "The data already exists, this transaction list will remove from the list!");
        }

        public void RetryCreateOrder(CreateOrder data, string Id, string IdTxn)
        {
            if (data == null) return;

            // Delete first the record on database
            _transactionFailedRepository.Delete(Id);

            // Check if MfgOrder Already exists
            if (!_opcenterCheckData.MfgOrderExists(data.MfgOrderName))
            {
                _opcenterSaveData.SaveMfgOrder(data, IdTxn);
            } else
            {
                ShowMessageAlreadyExists();
            }
        }

        public void RetryStartUnit(StartUnit data, string Id, string IdTxn)
        {
            if (data == null) return;

            // Delete first the record on database
            _transactionFailedRepository.Delete(Id);

            // Check if Container already exists
            if (!_opcenterCheckData.IsContainerExists(data.ContainerName))
            {
                _opcenterSaveData.StartContainerMainUnit(data, IdTxn);
            }
            else
            {
                ShowMessageAlreadyExists();
            }
        }

        public void RetryStartMaterial(StartMaterial data, string Id, string IdTxn)
        {
            List<ContainerAttrDetail> containerAttrDetails = new List<ContainerAttrDetail>();

            if (data == null) return;

            // Delete first the record on database
            _transactionFailedRepository.Delete(Id);

            // check if the Material already exists
            if (!_opcenterCheckData.IsContainerExists(data.CustomerSerialNumber))
            {
                SummaryMaterial summaryMaterial = null;
                var result = _opcenterSaveData.StartTheMaterial(data, IdTxn, ref summaryMaterial);

                if (result)
                {
                    if (summaryMaterial != null)
                        containerAttrDetails.Add(new ContainerAttrDetail()
                        {
                            Name = $"SummaryMaterial_{data.CustomerSerialNumber}",
                            DataType = TrivialTypeEnum.String,
                            AttributeValue = JsonSerializer.Serialize(summaryMaterial),
                            IsExpression = false
                        });

                    var statusAttr = _opcenterSaveData.StoreTheContainerAttribute(new ContainerAttribute() { ContainerName = data.SerialNumberReference, ContainerAttrDetails = containerAttrDetails }, IdTxn);
                    if (!statusAttr) ZIAlertBox.Warning("Warning Message", $"Success proceed the material {data.Product} with SN {data.CustomerSerialNumber}, but storing the Attribute Failed, please check Menu Transaction Failed");
                    else ZIAlertBox.Success("Finish Message", $"Success proceed the material {data.Product} with SN {data.CustomerSerialNumber}");
                }
            } else
            {
                ShowMessageAlreadyExists();
            }
        }

        public void RetryContainerAttribute(ContainerAttribute data, string Id, string IdTxn)
        {
            if (data == null) return;

            // Delete first the record on database
            _transactionFailedRepository.Delete(Id);
            
            // Retry The Container Attribute
            var statusAttr = _opcenterSaveData.StoreTheContainerAttribute(data, IdTxn);
            if (!statusAttr) ZIAlertBox.Error("Error Message", $"Retry Container Attribute still failed!");
            else ZIAlertBox.Success("Finish Message", $"Success Store Container Attribute!");
        }

        public void RetryTheTransaction(Entity.TransactionFailed transactionFailed)
        {
            switch (transactionFailed.TypeTransaction)
            {
                case TypeTransaction.StartMaterial:
                    RetryStartMaterial(ExtractRecordTransaction<StartMaterial>(transactionFailed), transactionFailed.Id, transactionFailed.IdTxn);
                    break;
                case TypeTransaction.StartUnit:
                    RetryStartUnit(ExtractRecordTransaction<StartUnit>(transactionFailed), transactionFailed.Id, transactionFailed.IdTxn);
                    break;
                case TypeTransaction.CreateOrder:
                    RetryCreateOrder(ExtractRecordTransaction<CreateOrder>(transactionFailed), transactionFailed.Id, transactionFailed.IdTxn);
                    break;
                case TypeTransaction.ContainerAttribute:
                    RetryContainerAttribute(ExtractRecordTransaction<ContainerAttribute>(transactionFailed), transactionFailed.Id, transactionFailed.IdTxn);
                    break;
            }
        }

        private T ExtractRecordTransaction<T>(Entity.TransactionFailed transactionFailed)
        {
            return JsonSerializer.Deserialize<T>(transactionFailed.DataTransaction);
        }
    }
}
