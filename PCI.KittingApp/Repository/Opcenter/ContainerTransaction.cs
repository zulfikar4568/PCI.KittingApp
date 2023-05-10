using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Config;
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
        }public bool ContainerExists(string ContainerName)
        {
            // Container Info
            ViewContainerStatus_Info containerInfo = new ViewContainerStatus_Info();
            containerInfo.ContainerName = new Info(true);

            ViewContainerStatus containerStatus = _containerTxn.ContainerInfo(containerInfo, ContainerName, true);

            if (containerStatus is null) return false;
            return true;
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
