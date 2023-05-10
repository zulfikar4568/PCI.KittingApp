using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingCustomerSN
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();

        [TestMethod]
        public void CorrectSN()
        {
            string customerSN = "5918748_01_IDN00001";
            string FG = "IDN00001";
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };

            kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG).Should().BeEquivalentTo(correctValue);
        }
        [TestMethod]
        public void WrongSN()
        {
            string customerSN = "5918748_01_IDN00002";
            string FG = "IDN00001";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_SN_MISSMATCH };

            kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG).Should().BeEquivalentTo(wrongValue);
        }
        [TestMethod]
        public void WrongCustomerSN()
        {
            string customerSN = "WrongSN";
            string FG = "IDN00001";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_FORMAT_CUSTOMER_SN };

            kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG).Should().BeEquivalentTo(wrongValue);
        }
    }
}
