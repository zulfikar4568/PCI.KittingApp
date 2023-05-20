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
        public bool ExecuteStart(string ContainerName, string MfgOrder = "", string ProductName = "", string ProductRevision = "", string WorkflowName = "", string WorkflowRevision = "", string Level = "", string Owner = "", string StartReason = "", string PriorityCode = "", double Qty = 0, string UOM = "", string Comments = "", string TxnDateStr = "", bool IgnoreException = true)
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
    }
}
