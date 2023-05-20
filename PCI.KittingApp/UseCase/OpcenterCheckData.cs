using PCI.KittingApp.Components;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCI.KittingApp.UseCase
{
    public class OpcenterCheckData
    {
        private MaintenanceTransaction _maintenanceTransaction;
        private ContainerTransaction _containerTransaction;
        public OpcenterCheckData(MaintenanceTransaction maintenanceTransaction, ContainerTransaction containerTransaction)
        {
            _maintenanceTransaction = maintenanceTransaction;
            _containerTransaction = containerTransaction;
        }
        public bool IsMfgOrderExists(string MfgOrderName)
        {
            if (!_maintenanceTransaction.MfgOrderExists(MfgOrderName))
            {
                ZIMessageBox.Show($"Mfg Order {MfgOrderName} not found!", "Not Found Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool IsContainerExists(string ContainerName)
        {
            return _containerTransaction.ContainerExists(ContainerName);
        }
        public bool IsProductExists(string ProductName)
        {
            if (!_maintenanceTransaction.ProductExists(ProductName))
            {
                ZIMessageBox.Show($"Product {ProductName} not found!", "Not Found Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool IsUOMExists(string UOMName)
        {
            if (!_maintenanceTransaction.UOMExists(UOMName))
            {
                ZIMessageBox.Show($"UOM {UOMName} not found!", "Not Found Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool IsQtyDouble(string Qty)
        {
            if (!Formatting.CanCovertTo<Double>(Qty))
            {
                ZIMessageBox.Show($"Qty {Qty} is not number!", "Type Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
