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
        public ContainerTransaction(Driver.Opcenter.ContainerTransaction containerTxn)
        {
            _containerTxn = containerTxn;
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
        public CurrentContainerStatus GetContainerStatusDetails(string ContainerName, string DataCollectionName = "", string DataCollectionRev = "", bool IgnoreException = true)
        {
            ContainerTxn serviceObject = new ContainerTxn();
            serviceObject.Container = new ContainerRef(ContainerName);
            if (DataCollectionName != "")
            {
                serviceObject.DataCollectionDef = new RevisionedObjectRef() { Name = DataCollectionName, Revision = DataCollectionRev, RevisionOfRecord = (DataCollectionRev == "") };
            }
            return _containerTxn.ContainerStatusInfo(serviceObject, ContainerName, IgnoreException);
        }
        public bool ExecuteContainerAttrMaint(string ContainerName, ContainerAttrDetail[] Attributes, bool IgnoreException = true)
        {
            ContainerAttrMaintService service = new ContainerAttrMaintService(AppSettings.ExCoreUserProfile);
            ContainerAttrMaint serviceObject = new ContainerAttrMaint() { Container = new ContainerRef(ContainerName) };
            ContainerAttrDetail[] currentAttrs = GetContainerAttrDetails(ContainerName);
            if (currentAttrs != null)
            {
                foreach (ContainerAttrDetail attr in Attributes)
                {
                    foreach (var currentAttr in currentAttrs)
                    {
                        if (attr.Name == currentAttr.Attribute.Name)
                        {
                            attr.Attribute = currentAttr.Attribute;
                            break;
                        }
                    }
                }
                foreach (ContainerAttrDetail currentAttr in currentAttrs)
                {
                    bool bFoundAttr = false;
                    foreach (ContainerAttrDetail oAttr in Attributes)
                    {
                        if (oAttr.Name == currentAttr.Name)
                        {
                            bFoundAttr = true;
                            break;
                        }
                    }
                    if (!bFoundAttr)
                    {
                        Array.Resize(ref Attributes, Attributes.Length + 1);
                        Attributes[Attributes.Length - 1] = new ContainerAttrDetail() { Attribute = currentAttr.Attribute, Name = currentAttr.Name, DataType = currentAttr.DataType, AttributeValue = currentAttr.AttributeValue, IsExpression = currentAttr.IsExpression };
                    }
                }
            }

            serviceObject.ServiceDetails = Attributes;

            return _containerTxn.ContainerAttrTxn(serviceObject, service, IgnoreException);
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
