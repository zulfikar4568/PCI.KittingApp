using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
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
            ZIMessageBox.Show("The data already exists, this transaction list will remove from the list!", "Data Already Exists!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (data == null) return;

            // Delete first the record on database
            _transactionFailedRepository.Delete(Id);

            // check if the Material already exists
            if (!_opcenterCheckData.IsContainerExists(data.CustomerSerialNumber))
            {
                var result = _opcenterSaveData.StartTheMaterial(data, IdTxn);
                if (result) ZIMessageBox.Show($"Success proceed the material {data.Product} with SN {data.CustomerSerialNumber}", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                ShowMessageAlreadyExists();
            }
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
            }
        }

        private T ExtractRecordTransaction<T>(Entity.TransactionFailed transactionFailed)
        {
            return JsonSerializer.Deserialize<T>(transactionFailed.DataTransaction);
        }
    }
}
