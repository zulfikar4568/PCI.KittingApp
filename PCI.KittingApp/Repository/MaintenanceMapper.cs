using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository
{
    public class MaintenanceMapper
    {
        public BillOfMaterial[] ExtractBOMFromERPBOM(ERPBOMChanges eRPBOMChanges)
        {
            List<BillOfMaterial> result = new List<BillOfMaterial>();

            if (eRPBOMChanges == null) return null;
            if (eRPBOMChanges.MaterialList.Length == 0 || eRPBOMChanges.MaterialList == null) return null;
            foreach (var item in eRPBOMChanges.MaterialList)
            {
                if (item == null) continue;
                if (item.Product == null) continue;
                if (item.Product.Name == null) continue;
                if (item.isProductDescription == null) continue;
                if (item.IssueControl == null) continue;

                result.Add(new BillOfMaterial()
                {
                    Product = item.Product.Name,
                    Description = item.isProductDescription.ToString(),
                    IssueControl = item.IssueControl,
                    QtyRequired = item.QtyRequired.Value
                });
            }
            return result.ToArray();
        }
    }
}
