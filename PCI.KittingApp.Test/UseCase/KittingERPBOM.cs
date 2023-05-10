using Camstar.WCF.ObjectStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;
using System.Collections.Generic;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingERPBOM
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();

        [TestMethod]
        public void ValidateCorrectPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "GH591875000";
            Assert.AreEqual(true, kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, ref BOMsMock));
            foreach (var item in BOMsMock)
            {
                if (item.Product == partNumber)
                {
                    Assert.AreEqual(true, item.isRegistered);
                }
            }
        }
        [TestMethod]
        public void ValidateAlreadyRegisteredPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "GH591875200";
            Assert.AreEqual(false, kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, ref BOMsMock));
            foreach (var item in BOMsMock)
            {
                if (item.Product == partNumber)
                {
                    Assert.AreEqual(true, item.isRegistered);
                }
            }
        }
        [TestMethod]
        public void ValidateIssueControlPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "GH526236500";
            Assert.AreEqual(false, kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, ref BOMsMock));
            foreach (var item in BOMsMock)
            {
                if (item.Product == partNumber)
                {
                    Assert.AreEqual(false, item.isRegistered);
                }
            }
        }
        [TestMethod]
        public void ValidateWrongPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "WRONGPN001";
            Assert.AreEqual(false, kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, ref BOMsMock));
        }

        public BillOfMaterial[] billOfMaterialsMock()
        {
            var BOMs = new List<BillOfMaterial>
            {
                new BillOfMaterial() { Product = "GH591874800", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH591874900", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH591875000", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH591875100", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH591875200", Description = "ABC", isRegistered = true, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH526236500", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.StockPointOnly, QtyRequired = 1 }
            };

            return BOMs.ToArray();
        }
    }
}
