using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Components;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.TransactionFailedType;
using PCI.KittingApp.Repository;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;

namespace PCI.KittingApp.UseCase
{
    public class OpcenterSaveData
    {

        private MaintenanceTransaction _maintenanceTransaction;
        private ContainerTransaction _containerTransaction;
        private MaintenanceMapper _maintenanceMapper;
        private Repository.SQLite.TransactionFailed _transactionFailedRepository;
        private OpcenterCheckData _opcenterCheckData;
        public OpcenterSaveData(MaintenanceTransaction maintenanceTransaction, ContainerTransaction containerTransaction, MaintenanceMapper maintenanceMapper, Repository.SQLite.TransactionFailed transactionFailedRepository, OpcenterCheckData opcenterCheckData)
        {
            _maintenanceTransaction = maintenanceTransaction;
            _containerTransaction = containerTransaction;
            _maintenanceMapper = maintenanceMapper;
            _transactionFailedRepository = transactionFailedRepository;
            _opcenterCheckData = opcenterCheckData;
        }

        public void SaveMfgOrder(CreateOrder data)
        {
            bool result = _maintenanceTransaction.SaveMfgOrder(data.MfgOrderName, "", "", data.ProductName, "", "", "", Convert.ToDouble(data.Qty), null, "", data.UOM);
            if (result)
            {
                ZIMessageBox.Show($"Order {data.MfgOrderName} save succussfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = Entity.TypeTransaction.CreateOrder,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now
                });
                ZIMessageBox.Show($"Failed Create Order {data.MfgOrderName}, please see on Transaction Failed, and click retry icon!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StartContainerMainUnit(StartUnit data)
        {
            var result = _containerTransaction.ExecuteStart(data.ContainerName, data.MfgOrderName, "", "", data.ProductDefaultStart.Workflow, "", data.ProductDefaultStart.StartLevel, data.ProductDefaultStart.StartOwner, data.ProductDefaultStart.StartReason, "", data.ProductDefaultStart.StartQty, data.ProductDefaultStart.StartUOM);
            if (result)
            {
                ZIMessageBox.Show("Success Start the Container", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.StartUnit,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now,
                });
                ZIMessageBox.Show($"Failed Start the Container {data.ContainerName}, please see on Transaction Failed, and click retry icon!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegisterAllBillOfMaterial(BillOfMaterial[] BOMs, string SerialNumberReference)
        {
            bool flagOneMaterialFail = false;
            foreach (var item in BOMs)
            {
                var result = StartTheMaterial(new StartMaterial() { CustomerSerialNumber = item.CustomerSerialNumber, Product = item.Product, BatchID = item.BatchID, SerialNumberReference = SerialNumberReference, ProductDefaultStart = item.ProductDefaultStart });
                if (!result && !flagOneMaterialFail) flagOneMaterialFail = true;
            }
            if (!flagOneMaterialFail)
            {
                ZIMessageBox.Show("Success proceed all BOM to MES", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                ZIMessageBox.Show("Finish the process the BOM to MES, but there's some fail material to start", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool StartTheMaterial(StartMaterial data)
        {
            var result = _containerTransaction.ExecuteStart(data.CustomerSerialNumber, "", "", "", data.ProductDefaultStart.Workflow, "", data.ProductDefaultStart.StartLevel, data.ProductDefaultStart.StartOwner, data.ProductDefaultStart.StartReason, "", data.ProductDefaultStart.StartQty, data.ProductDefaultStart.StartUOM, "", "", data.SerialNumberReference, data.BatchID);
            if (!result)
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.StartMaterial,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now,
                });
            }

            if (!result)
            {
                ZIMessageBox.Show($"Material {data.Product} fail to start, please see the Transaction Failed, and please retry icon", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
    }
}
