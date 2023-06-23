using Camstar.Util;
using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Config;
using PCI.KittingApp.Driver.Opcenter;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository.Opcenter
{
    public class ContainerTransaction
    {
        private readonly Driver.Opcenter.ContainerTransaction _containerTxn;
        private readonly Helper _helper;
        public ContainerTransaction(Driver.Opcenter.ContainerTransaction containerTxn, Helper helper)
        {
            _containerTxn = containerTxn;
            _helper = helper;
        }
        public bool ContainerExists(string ContainerName)
        {
            // Container Info
            ViewContainerStatus_Info containerInfo = new ViewContainerStatus_Info();
            containerInfo.ContainerName = new Info(true);

            ViewContainerStatus containerStatus = _containerTxn.ContainerInfo(containerInfo, ContainerName, true);

            if (containerStatus is null) return false;
            return true;
        }
        public bool ExecuteStart(string ContainerName, string MfgOrder = "", string ProductName = "", string ProductRevision = "", string WorkflowName = "", string WorkflowRevision = "", string Level = "", string Owner = "", string StartReason = "", string PriorityCode = "", double Qty = 0, string UOM = "", string Comments = "", string TxnDateStr = "", string SerialNumberRefrence = "", string BatchID = "", bool IgnoreException = true)
        {
            StartService service = new StartService(AppSettings.ExCoreUserProfile);
            Start serviceObject = new Start();
            serviceObject.Details = new StartDetails();
            serviceObject.CurrentStatusDetails = new CurrentStatusStartDetails();
            serviceObject.Details.ContainerName = new Primitive<string>() { Value = ContainerName };
            if (MfgOrder != "") serviceObject.Details.MfgOrder = new NamedObjectRef(MfgOrder);
            if (ProductName != "" && ProductRevision != "")
            {
                serviceObject.Details.Product = new RevisionedObjectRef(ProductName, ProductRevision);
            }
            else if (ProductName != "")
            {
                serviceObject.Details.Product = new RevisionedObjectRef(ProductName);
            }
            if (WorkflowName != "" && WorkflowRevision != "")
            {
                serviceObject.CurrentStatusDetails.Workflow = new RevisionedObjectRef(WorkflowName, WorkflowRevision);
            }
            else if (WorkflowName != "")
            {
                serviceObject.CurrentStatusDetails.Workflow = new RevisionedObjectRef(WorkflowName);
            }
            if (SerialNumberRefrence != "") serviceObject.Details.pciSerialNumberReference = SerialNumberRefrence;
            if (BatchID != "") serviceObject.Details.pciBatchID = BatchID;
            if (Level != "") serviceObject.Details.Level = new NamedObjectRef(Level);
            if (Owner != "") serviceObject.Details.Owner = new NamedObjectRef(Owner);
            if (StartReason != "") serviceObject.Details.StartReason = new NamedObjectRef(StartReason);
            if (PriorityCode != "") serviceObject.Details.PriorityCode = new NamedObjectRef(PriorityCode);
            if (UOM != "") serviceObject.Details.UOM = new NamedObjectRef(UOM);
            if (Comments != "") serviceObject.Comments = Comments;
            if (Formatting.IsDate(TxnDateStr)) serviceObject.TxnDate = Convert.ToDateTime(TxnDateStr);

            return _containerTxn.StartTxn(serviceObject, service, IgnoreException);
        }
        public ViewContainerStatus GetCurrentContainer(string ContainerName, bool IgnoreException = true)
        {
            ViewContainerStatus_Info containerInfo = new ViewContainerStatus_Info();
            containerInfo.RequestValue = true;
            containerInfo.ContainerName = new Info(true);
            containerInfo.Step = new Info(true);
            containerInfo.Qty = new Info(true);
            containerInfo.Product = new Info(true);
            containerInfo.Operation = new Info(true);
            containerInfo.Product = new Info(true);
            return _containerTxn.ContainerInfo(containerInfo, ContainerName, IgnoreException);
        }
        public bool ExecuteContainerAttrMaint(string ContainerName, ContainerAttrDetail[] Attributes, string Comments = "", bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            ContainerAttrMaintService oService = null;
            try
            {
                string sMessage = "";
                oService = new ContainerAttrMaintService(AppSettings.ExCoreUserProfile);

                ContainerAttrMaint oServiceObject = new ContainerAttrMaint() { Container = new ContainerRef(ContainerName) };
                ContainerAttrMaint_Request oServiceRequest = new ContainerAttrMaint_Request();
                oServiceRequest.Info = new ContainerAttrMaint_Info();
                oServiceRequest.Info.ServiceDetails = new ContainerAttrDetail_Info();
                oServiceRequest.Info.ServiceDetails.Attribute = new Info(true);
                oServiceRequest.Info.ServiceDetails.Name = new Info(true);
                oServiceRequest.Info.ServiceDetails.DataType = new Info(true);
                oServiceRequest.Info.ServiceDetails.AttributeValue = new Info(true);
                oServiceRequest.Info.ServiceDetails.IsExpression = new Info(true);
                ContainerAttrMaint_Result oServiceResult = null;
                ResultStatus oResultStatus = oService.GetAttributes(oServiceObject, oServiceRequest, out oServiceResult);
                if (_helper.ProcessResult(oResultStatus, ref sMessage, false))
                {
                    ContainerAttrDetail[] cCurrentAttrs = oServiceResult.Value.ServiceDetails;

                    EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Setting input data for ContainerAttrMaint ..."), System.Diagnostics.EventLogEntryType.Information, 3);

                    oServiceObject = new ContainerAttrMaint() { Container = new ContainerRef(ContainerName) };
                    if (cCurrentAttrs != null)
                    {
                        foreach (ContainerAttrDetail oAttr in Attributes)
                        {
                            foreach (var oCurrentAttr in cCurrentAttrs)
                            {
                                if (oAttr.Name == oCurrentAttr.Attribute.Name)
                                {
                                    oAttr.Attribute = oCurrentAttr.Attribute;
                                    break;
                                }
                            }
                        }
                        foreach (ContainerAttrDetail oCurrentAttr in cCurrentAttrs)
                        {
                            bool bFoundAttr = false;
                            foreach (ContainerAttrDetail oAttr in Attributes)
                            {
                                if (oAttr.Name == oCurrentAttr.Name)
                                {
                                    bFoundAttr = true;
                                    break;
                                }
                            }
                            if (!bFoundAttr)
                            {
                                Array.Resize(ref Attributes, Attributes.Length + 1);
                                Attributes[Attributes.Length - 1] = new ContainerAttrDetail() { Attribute = oCurrentAttr.Attribute, Name = oCurrentAttr.Name, DataType = oCurrentAttr.DataType, AttributeValue = oCurrentAttr.AttributeValue, IsExpression = oCurrentAttr.IsExpression };
                            }
                        }
                    }

                    oServiceObject.ServiceDetails = Attributes;
                    if (Comments != "") oServiceObject.Comments = Comments;

                    EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, "Executing ContainerAttrMaint ..."), System.Diagnostics.EventLogEntryType.Information, 3);
                    oResultStatus = oService.ExecuteTransaction(oServiceObject);
                    bool ExecuteContainerAttrStatus = _helper.ProcessResult(oResultStatus, ref sMessage, false);
                    EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 3);
                    return ExecuteContainerAttrStatus;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public ContainerAttrDetail[] GetContainerAttrDetails(string ContainerName, bool IgnoreException = true)
        {
            ContainerAttrMaint_Info containerAttrInfo = new ContainerAttrMaint_Info();
            containerAttrInfo.ServiceDetails = new ContainerAttrDetail_Info();

            containerAttrInfo.ServiceDetails.Attribute = new Info(true);
            containerAttrInfo.ServiceDetails.Name = new Info(true);
            containerAttrInfo.ServiceDetails.DataType = new Info(true);
            containerAttrInfo.ServiceDetails.AttributeValue = new Info(true);
            containerAttrInfo.ServiceDetails.IsExpression = new Info(true);

            return _containerTxn.GetContainerAttrDetails(containerAttrInfo, ContainerName, IgnoreException);
        }
    }
}
