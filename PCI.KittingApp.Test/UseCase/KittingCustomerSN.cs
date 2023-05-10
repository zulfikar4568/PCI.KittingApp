using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(true, kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG));
        }
        [TestMethod]
        public void WrongSN()
        {
            string customerSN = "5918748_01_IDN00002";
            string FG = "IDN00001";
            Assert.AreEqual(false, kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG));
        }
        [TestMethod]
        public void WrongCustomerSN()
        {
            string customerSN = "WrongSN";
            string FG = "IDN00001";
            Assert.AreEqual(false, kittingUsecase.ValidateCustomerSerialNumber(customerSN, FG));
        }
    }
}
