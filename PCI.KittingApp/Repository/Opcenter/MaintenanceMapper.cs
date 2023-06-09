﻿using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Config;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Repository.Opcenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository
{
    public class MaintenanceMapper
    {
        private MaintenanceTransaction _maintenanceTransaction;
        public MaintenanceMapper(MaintenanceTransaction maintenanceTransaction)
        {
            _maintenanceTransaction = maintenanceTransaction;
        }
        public BillOfMaterial[] ExtractBOMFromERPBOM(ERPBOMChanges eRPBOMChanges, IssueControlEnum issueControlFilter = IssueControlEnum.NoTracking)
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
                if (item.IssueControl != issueControlFilter) continue;

                var defaultProductData = ExtractDefaultData(_maintenanceTransaction.GetProduct(item.Product.Name));
                if (defaultProductData == null) continue;

                result.Add(new BillOfMaterial()
                {
                    Product = item.Product.Name,
                    Description = item.isProductDescription.ToString(),
                    IssueControl = item.IssueControl,
                    QtyRequired = item.QtyRequired.Value,
                    ProductDefaultStart = defaultProductData,
                    
                });
            }
            return result.ToArray();
        }

        public ProductDefaultStart ExtractDefaultDataFromMfgOrder(MfgOrderChanges mfgOrderChanges)
        {
            if (mfgOrderChanges == null) return null;
            if (mfgOrderChanges.Product == null) return null;
            if (mfgOrderChanges.Product.Name.ToString() == "") return null;
            ProductChanges productChanges = _maintenanceTransaction.GetProduct(mfgOrderChanges.Product.Name);
            return ExtractDefaultData(productChanges);
        }

        public ProductDefaultStart ExtractDefaultData(ProductChanges productChanges)
        {
            if (productChanges == null) return null;
            if (CheckingTheDefaultProductData(productChanges)) return null;

            return new ProductDefaultStart()
            {
                StartLevel = productChanges.StdStartLevel.Name,
                StartOwner = productChanges.StdStartOwner.Name,
                StartQty = productChanges.StdStartQty.Value,
                StartReason = productChanges.StdStartReason.Name,
                StartUOM = productChanges.StdStartUOM.Name,
                Workflow = productChanges.Workflow.Name,
                PathPrinter = productChanges.pciPathPrinter != null ? productChanges.pciPathPrinter.Value : AppSettings.DefaultPathPrinter
            };
        }

        private bool CheckingTheDefaultProductData(ProductChanges productChanges)
        {
            return productChanges.StdStartLevel == null || productChanges.StdStartOwner == null || productChanges.StdStartQty == null || productChanges.StdStartReason == null || productChanges.StdStartUOM == null || productChanges.Workflow == null;
        }
    }
}
