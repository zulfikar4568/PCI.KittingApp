using Camstar.WCF.ObjectStack;
using FluentAssertions;
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
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };

            // Validate the PN can be registered
            kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, BOMsMock).Should().BeEquivalentTo(correctValue);
        }
        [TestMethod]
        public void ValidateAlreadyRegisteredPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "GH591875200";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_REGISTERED };

            // Validate the PN can't be registered because the status already registered
            kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, BOMsMock).Should().BeEquivalentTo(wrongValue);
        }
        [TestMethod]
        public void ValidateIssueControlPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "GH526236500";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_ISSUE_CONTROL };

            // Validate the PN can't be registered because the Issue Control not serialized
            kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, BOMsMock).Should().BeEquivalentTo(wrongValue);
        }
        [TestMethod]
        public void ValidateWrongPN()
        {
            var BOMsMock = billOfMaterialsMock();
            var partNumber = "WRONGPN001";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_WRONG_PN };

            kittingUsecase.ValidatePNAssociatedWithERPBOM(partNumber, BOMsMock).Should().BeEquivalentTo(wrongValue);
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
