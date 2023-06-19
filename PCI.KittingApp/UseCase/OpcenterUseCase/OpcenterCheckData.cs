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
        public MfgOrderChanges GetMfgOrderInformation(string MfgOrderName)
        {
            MfgOrderChanges mfgOrderChanges = _maintenanceTransaction.GetMfgOrder(MfgOrderName);
            if (mfgOrderChanges == null)
            {
                ZIAlertBox.Warning("Not Found", "Mfg Order data cannot be found!");
                return null;
            }
            return mfgOrderChanges;
        }
        public ProductDefaultStart ProductDefaultDataFromMfgOrder(MfgOrderChanges MfgOrderChanges)
        {
            ProductDefaultStart productDefaultStart = _maintenanceMapper.ExtractDefaultDataFromMfgOrder(MfgOrderChanges);
            if (productDefaultStart == null)
            {
                ZIAlertBox.Warning("Data Not Complete", "Metadata modelling is not complete, please check product definition in MES (StartLevel, StartOwner, StartReason, StartQty, StartUOM)!");
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
                ZIAlertBox.Warning("Not Found", $"Mfg Order {MfgOrderName} not found!");
                return false;
            }
            return true;
        }
        public bool IsMfgOrderNotExists(string MfgOrderName)
        {
            if (_maintenanceTransaction.MfgOrderExists(MfgOrderName))
            {
                ZIAlertBox.Warning("Validate Message", $"Mfg Order {MfgOrderName} already exists!");
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
                ZIAlertBox.Warning("Not Found Message", $"Product {ProductName} not found!");
                return false;
            }
            return true;
        }

        public bool IsUOMExists(string UOMName)
        {
            if (!_maintenanceTransaction.UOMExists(UOMName))
            {
                ZIAlertBox.Warning("Not Found Message", $"UOM {UOMName} not found!");
                return false;
            }
            return true;
        }

        public bool IsQtyDouble(string Qty)
        {
            if (!Formatting.CanCovertTo<Double>(Qty))
            {
                ZIAlertBox.Warning("Type Error Message", $"Qty {Qty} is not number!");
                return false;
            }
            return true;
        }
    }
}
