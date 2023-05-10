using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Tests
{
    [TestClass()]
    public class KittingFGSerialNumber
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();

        [TestMethod()]
        public void NormalSNTest()
        {
            string FGSerialNumber1 = "IDN00001";
            string FGSerialNumber2 = "IDN00002";
            string FGSerialNumber3 = "IDN00003";
            Assert.AreEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerExistsMock));
            Assert.AreEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerExistsMock));
            Assert.AreEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerExistsMock));
        }
        [TestMethod()]
        public void CapitalSNTest()
        {
            string FGSerialNumber1 = "idn00001";
            string FGSerialNumber2 = "Idn00002";
            string FGSerialNumber3 = "iDN00003";
            string FGSerialNumber4 = "IDN00003";
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerExistsMock));
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerExistsMock));
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerExistsMock));
            Assert.AreEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber4, ContainerExistsMock));
        }

        [TestMethod()]
        public void DigitSNTest()
        {
            string FGSerialNumber1 = "IDN00001";
            string FGSerialNumber2 = "IDN000002";
            string FGSerialNumber3 = "IDN0003";
            Assert.AreEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerExistsMock));
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerExistsMock));
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerExistsMock));
        }

        [TestMethod()]
        public void IsNotExistsSNTest()
        {
            string FGSerialNumber1 = "IDN00001";
            Assert.AreNotEqual(true, kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerDoesntExistsMock));
        }

        public bool ContainerExistsMock(string FGSerialNumber)
        {
            return true;
        }

        public bool ContainerDoesntExistsMock(string FGSerialNumber)
        {
            return false;
        }
    }
}