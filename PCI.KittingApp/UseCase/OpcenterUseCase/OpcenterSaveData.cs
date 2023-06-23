using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Components;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Summary;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Repository;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.UseCase;
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
        private Repository.SQLite.TransactionFailed _transactionFailedRepository;
        private PrintingLabelUseCase _printingLabelUseCase;
        public OpcenterSaveData(MaintenanceTransaction maintenanceTransaction, ContainerTransaction containerTransaction, Repository.SQLite.TransactionFailed transactionFailedRepository, PrintingLabelUseCase printingLabelUseCase)
        {
            _maintenanceTransaction = maintenanceTransaction;
            _containerTransaction = containerTransaction;
            _transactionFailedRepository = transactionFailedRepository;
            _printingLabelUseCase = printingLabelUseCase;
        }

        public void SaveMfgOrder(CreateOrder data, string IdTxn)
        {
            bool result = _maintenanceTransaction.SaveMfgOrder(data.MfgOrderName, "", "", data.ProductName, "", "", "", Convert.ToDouble(data.Qty), null, "", data.UOM);
            if (result)
            {
                ZIAlertBox.Success("Success Message", $"Order {data.MfgOrderName} save successfully!");
            } else
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.CreateOrder,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now,
                    IdTxn = IdTxn,
                });
                ZIAlertBox.Error("Failed Message", $"Failed Create Order {data.MfgOrderName}, please see on Transaction Failed, and click retry icon!");
            }
        }

        public void StartContainerMainUnit(StartUnit data, string IdTxn)
        {
            var result = _containerTransaction.ExecuteStart(data.ContainerName, data.MfgOrderName, "", "", data.ProductDefaultStart.Workflow, "", data.ProductDefaultStart.StartLevel, data.ProductDefaultStart.StartOwner, data.ProductDefaultStart.StartReason, "", data.ProductDefaultStart.StartQty, data.ProductDefaultStart.StartUOM);
            if (result)
            {
                // Print the Label
                _printingLabelUseCase.StartPrintingLabel(_printingLabelUseCase.GenerateDataFromStartUnit(data, IdTxn), true);

                // Storing Attribute
                SummaryUnit summaryUnit = new SummaryUnit() { VersanaSN = data.ContainerName, KittingEmployee = Main.currentUserSession.FullName};
                List<ContainerAttrDetail> containerAttrDetails = new List<ContainerAttrDetail>
                {
                    new ContainerAttrDetail()
                    {
                        Name = "SummaryUnit",
                        DataType = TrivialTypeEnum.String,
                        AttributeValue = JsonSerializer.Serialize(summaryUnit),
                        IsExpression = false
                    }
                };

                bool statusAttr = StoreTheContainerAttribute(new ContainerAttribute() { ContainerName = data.ContainerName, ContainerAttrDetails = containerAttrDetails }, IdTxn);
                if (statusAttr) ZIAlertBox.Success("Success Message", $"Success Start the Container {data.ContainerName}");
                else ZIAlertBox.Warning("Warning Message", $"Start Container {data.ContainerName} Success but storing AttributeFailed, please check Transaction Failed Menu!");
                
            }
            else
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.StartUnit,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now,
                    IdTxn = IdTxn,
                });
                ZIAlertBox.Error("Failed Message", $"Failed Start the Container {data.ContainerName}, please see on Transaction Failed, and click retry icon!");
            }
        }

        public bool StoreTheContainerAttribute(ContainerAttribute Data, string IdTxn)
        {
            if (Data.ContainerAttrDetails.Count == 0) return true;
            var statusAttr = _containerTransaction.ExecuteContainerAttrMaint(Data.ContainerName, Data.ContainerAttrDetails.ToArray());
            if (!statusAttr)
            {
                // We need to store into transaction failed
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.ContainerAttribute,
                    DataTransaction = JsonSerializer.Serialize(Data),
                    DateTransaction = DateTime.Now,
                    IdTxn = IdTxn,
                });
                return false;
            }
            return true;
        }

        public void RegisterAllBillOfMaterial(BillOfMaterial[] BOMs, string SerialNumberReference)
        {
            // Field
            bool flagOneMaterialFail = false;
            string TxnId = Guid.NewGuid().ToString();
            List<ContainerAttrDetail> containerAttrDetails= new List<ContainerAttrDetail>();

            // Start the Logic
            foreach (var item in BOMs)
            {
                SummaryMaterial summaryMaterial = null;
                var result = StartTheMaterial(new StartMaterial() { CustomerSerialNumber = item.CustomerSerialNumber, Product = item.Product, BatchID = item.BatchID, SerialNumberReference = SerialNumberReference, ProductDefaultStart = item.ProductDefaultStart }, TxnId, ref summaryMaterial);
                if (!result && !flagOneMaterialFail) flagOneMaterialFail = true;
                if (result)
                {
                    if(summaryMaterial != null) 
                        containerAttrDetails.Add(new ContainerAttrDetail() { 
                            Name = $"SummaryMaterial_{item.CustomerSerialNumber}",
                            DataType = TrivialTypeEnum.String,
                            AttributeValue = JsonSerializer.Serialize(summaryMaterial), 
                            IsExpression = false 
                        });
                }
            }

            var statusAttr = StoreTheContainerAttribute(new ContainerAttribute() { ContainerName = SerialNumberReference, ContainerAttrDetails = containerAttrDetails }, TxnId);
            
            if (!flagOneMaterialFail && statusAttr)
            {
                ZIAlertBox.Success("Success Message", "Success proceed all BOM to MES");
            } else if (flagOneMaterialFail && statusAttr)
            {
                ZIAlertBox.Warning("Warning Message", "Finish the process the BOM to MES, but there's some fail material to start, please check Transaction Failed!");
            } else if (!flagOneMaterialFail && !statusAttr)
            {
                ZIAlertBox.Warning("Warning Message", "Success proceed all BOM to MES, but storing Attribute Failed!, please check Menu Transaction Failed!");
            } else if (flagOneMaterialFail && !statusAttr)
            {
                ZIAlertBox.Warning("Warning Message", "Finish the process the BOM to MES, but there's some fail material to start and fail storing Attribute!, please check Menu Transaction Failed!");
            }
        }

        public bool StartTheMaterial(StartMaterial data, string IdTxn, ref SummaryMaterial summaryMaterial)
        {
            var result = _containerTransaction.ExecuteStart(data.CustomerSerialNumber, "", data.Product, "", data.ProductDefaultStart.Workflow, "", data.ProductDefaultStart.StartLevel, data.ProductDefaultStart.StartOwner, data.ProductDefaultStart.StartReason, "", data.ProductDefaultStart.StartQty, data.ProductDefaultStart.StartUOM, "", "", data.SerialNumberReference, data.BatchID);
            if (result)
            {
                // Print the Label
                _printingLabelUseCase.StartPrintingLabel(_printingLabelUseCase.GenerateDataFromStartMaterial(data, IdTxn), true);
            } else
            {
                _transactionFailedRepository.Insert(new Entity.TransactionFailed()
                {
                    TypeTransaction = TypeTransaction.StartMaterial,
                    DataTransaction = JsonSerializer.Serialize(data),
                    DateTransaction = DateTime.Now,
                    IdTxn = IdTxn,
                });
            }

            // Assign new Summary Material
            summaryMaterial = new SummaryMaterial() { VersanaSN = data.SerialNumberReference, CustomerSN = data.CustomerSerialNumber, KittingEmployee = Main.currentUserSession.FullName, MaterialPN = data.Product };

            if (!result)
            {
                ZIAlertBox.Error("Error Message", $"Material {data.Product} fail to start, please see the Transaction Failed, and please retry icon");
            }

            return result;
        }
    }
}
