using Camstar.WCF.ObjectStack;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;
using System.Collections.Generic;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingCustomerSNAlreadyUsed
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();

        [TestMethod]
        public void TestIfCustomerSerialNumberAlreadyUsed()
        {
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_CUSTOMER_SN_ALREADY_USED };
            var customerSNAlreadyUsed = "5918750_01_IDN00017";

            var validationStatus = kittingUsecase.CheckIfCustomerSNAlreadyUsedInBOM(billOfMaterialsMock(), customerSNAlreadyUsed);
            validationStatus.Should().BeEquivalentTo(wrongValue);
        }

        [TestMethod]
        public void TestIfCustomerSerialNumberNeverUsed()
        {
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };
            var customerSNNeverUsed = "5918752_01_IDN00017";

            var validationStatus = kittingUsecase.CheckIfCustomerSNAlreadyUsedInBOM(billOfMaterialsMock(), customerSNNeverUsed);
            validationStatus.Should().BeEquivalentTo(correctValue);
        }

        public BillOfMaterial[] billOfMaterialsMock()
        {
            var BOMs = new List<BillOfMaterial>
            {
                new BillOfMaterial() { Product = "GH591874800", Description = "ABC", isRegistered = true, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1, CustomerSerialNumber = "5918748_01_IDN00017" },
                new BillOfMaterial() { Product = "GH591874900", Description = "ABC", isRegistered = true, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1, CustomerSerialNumber = "5918751_01_IDN00017" },
                new BillOfMaterial() { Product = "GH591875000", Description = "ABC", isRegistered = true, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1, CustomerSerialNumber = "5918750_01_IDN00017" },
                new BillOfMaterial() { Product = "GH591875100", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH591875200", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.Serialized, QtyRequired = 1 },
                new BillOfMaterial() { Product = "GH526236500", Description = "ABC", isRegistered = false, IssueControl = IssueControlEnum.StockPointOnly, QtyRequired = 1 }
            };

            return BOMs.ToArray();
        }
    }
}
