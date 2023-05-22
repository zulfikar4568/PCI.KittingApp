using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Components;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Repository;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.UseCase
{
    public class OpcenterSaveData
    {

        private MaintenanceTransaction _maintenanceTransaction;
        private ContainerTransaction _containerTransaction;
        private MaintenanceMapper _maintenanceMapper;
        public OpcenterSaveData(MaintenanceTransaction maintenanceTransaction, ContainerTransaction containerTransaction, MaintenanceMapper maintenanceMapper)
        {
            _maintenanceTransaction = maintenanceTransaction;
            _containerTransaction = containerTransaction;
            _maintenanceMapper = maintenanceMapper;
        }

        public bool SaveMfgOrder(string MfgOrderName, string ProductName, string Qty, string UOM)
        {
            bool result = _maintenanceTransaction.SaveMfgOrder(MfgOrderName, "", "", ProductName, "", "", "", Convert.ToDouble(Qty), null, "", UOM);
            if (result)
            {
                ZIMessageBox.Show($"Order {MfgOrderName} save succussfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        public bool StartContainerMainUnit(string ContainerName, string MfgOrderName)
        {
            MfgOrderChanges mfgOrderChanges = _maintenanceTransaction.GetMfgOrder(MfgOrderName);
            if (mfgOrderChanges == null) return false;
            ProductDefaultStart productDefaultStart = _maintenanceMapper.ExtractDefaultDataFromMfgOrder(mfgOrderChanges);
            return productDefaultStart != null ? _containerTransaction.ExecuteStart(ContainerName, MfgOrderName, "", "", productDefaultStart.Workflow, "", productDefaultStart.StartLevel, productDefaultStart.StartOwner, productDefaultStart.StartReason, "", productDefaultStart.StartQty, productDefaultStart.StartUOM) : false;
        }

        public bool StartTheMaterial(string ContainerName, string ProductName, string BatchID, string SerialNnumberReference)
        {
            ProductDefaultStart productDefaultStart = _maintenanceMapper.ExtractDefaultData(_maintenanceTransaction.GetProduct(ProductName));
            return productDefaultStart != null ? _containerTransaction.ExecuteStart(ContainerName, "", "", "", productDefaultStart.Workflow, "", productDefaultStart.StartLevel, productDefaultStart.StartOwner, productDefaultStart.StartReason, "", productDefaultStart.StartQty, productDefaultStart.StartUOM, "", "", SerialNnumberReference, BatchID) : false;
        }
    }
}
