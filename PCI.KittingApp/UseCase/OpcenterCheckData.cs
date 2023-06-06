using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Components;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Repository;
using PCI.KittingApp.Repository.Opcenter;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace PCI.KittingApp.UseCase
{
    public class OpcenterCheckData
    {
        private MaintenanceTransaction _maintenanceTransaction;
        private ContainerTransaction _containerTransaction;
        private MaintenanceMapper _maintenanceMapper;
        public OpcenterCheckData(MaintenanceTransaction maintenanceTransaction, ContainerTransaction containerTransaction, MaintenanceMapper maintenanceMapper)
        {
            _maintenanceTransaction = maintenanceTransaction;
            _containerTransaction = containerTransaction;
            _maintenanceMapper = maintenanceMapper;
        }
        public ProductDefaultStart ProductDefaultDataFromMfgOrder(string MfgOrderName)
        {
            MfgOrderChanges mfgOrderChanges = _maintenanceTransaction.GetMfgOrder(MfgOrderName);
            if (mfgOrderChanges == null)
            {
                ZIMessageBox.Show("Mfg Order data cannot be found!");
                return null;
            }
            ProductDefaultStart productDefaultStart = _maintenanceMapper.ExtractDefaultDataFromMfgOrder(mfgOrderChanges);
            if (productDefaultStart == null)
            {
                ZIMessageBox.Show("Metadata modelling is not complete, please check product definition in MES (StartLevel, StartOwner, StartReason, StartQty, StartUOM)!");
            }
            return productDefaultStart;
        }
        public MaterialRegistration ExtractMaterialRequirementFromContainer(string ContainerName)
        {
            ViewContainerStatus containerData = _containerTransaction.GetCurrentContainer(ContainerName);
            if (containerData == null) return null;
            if (containerData.Product == null) return null;

            ProductChanges productData = _maintenanceTransaction.GetProduct(containerData.Product.ToString());
            if (productData == null) return null;
            if (productData.ERPBOM == null) return null;

            var erpBOMRevision = productData.ERPBOM.Revision == null ? "" : productData.ERPBOM.Revision;
            ERPBOMChanges eRPBOMData = _maintenanceTransaction.GetERPBOM(productData.ERPBOM.Name, erpBOMRevision);
            if (eRPBOMData == null) return null;
            if (eRPBOMData.MaterialList == null) return null;

            BillOfMaterial[] BOMs = _maintenanceMapper.ExtractBOMFromERPBOM(eRPBOMData);
            if (BOMs == null) return null;

            return new MaterialRegistration()
            {
                ProductName = productData.Name.ToString(),
                ERPBOMName = eRPBOMData.Name.ToString(),
                BillOfMaterial = BOMs,
            };
        }
        public string[] GetUOMList()
        {
            var dataUOM = _maintenanceTransaction.ListUOM();
            if (dataUOM == null) return null;
            return dataUOM.Select(x => x.Name).ToArray();
        }
        public bool MfgOrderExists(string MfgOrderName)
        {
            return _maintenanceTransaction.MfgOrderExists(MfgOrderName);
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
        public bool IsMfgOrderNotExists(string MfgOrderName)
        {
            if (_maintenanceTransaction.MfgOrderExists(MfgOrderName))
            {
                ZIMessageBox.Show($"Mfg Order {MfgOrderName} already exists!", "Validate Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
