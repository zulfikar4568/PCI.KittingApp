using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingCustomerSNWithoutDelimiter
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();
        [TestMethod]
        public void ValidateCorrectSN()
        {
            string customerSerialNumber = "591874801IDN00047";
            string pciPartNumber = "GH591874800";
            string serialNumberFG = "IDN00047";

            var expectedResult = new ValidationStatus() { ErrorCode = null, IsSuccess = true };
            var result = kittingUsecase.ValidateCustomerSerialNumberWithoutDelimiter(customerSerialNumber, pciPartNumber, serialNumberFG);
            result.Should().BeEquivalentTo(expectedResult);
        }
        [TestMethod]
        public void ValidateWrongPN()
        {
            string customerSerialNumber = "591874801IDN00047";
            string pciPartNumber = "GH591875800";
            string serialNumberFG = "IDN00047";

            var expectedResult = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_MISSMATCH };
            var result = kittingUsecase.ValidateCustomerSerialNumberWithoutDelimiter(customerSerialNumber, pciPartNumber, serialNumberFG);
            result.Should().BeEquivalentTo(expectedResult);
        }
        [TestMethod]
        public void ValidateWrongSN()
        {
            string customerSerialNumber = "591874801IDN00047";
            string pciPartNumber = "GH591874800";
            string serialNumberFG = "IDN00048";

            var expectedResult = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_SN_MISSMATCH };
            var result = kittingUsecase.ValidateCustomerSerialNumberWithoutDelimiter(customerSerialNumber, pciPartNumber, serialNumberFG);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
