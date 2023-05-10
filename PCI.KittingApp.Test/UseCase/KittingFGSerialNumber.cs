using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCI.KittingApp.Entity;
using FluentAssertions;

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
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };

            // Do the test
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerDoesntExistsMock).Should().BeEquivalentTo(correctValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerDoesntExistsMock).Should().BeEquivalentTo(correctValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerDoesntExistsMock).Should().BeEquivalentTo(correctValue);
        }
        [TestMethod()]
        public void CapitalSNTest()
        {
            string FGSerialNumber1 = "idn00001";
            string FGSerialNumber2 = "Idn00002";
            string FGSerialNumber3 = "iDN00003";
            string FGSerialNumber4 = "IDN00003";
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_IDN };

            // Do the test
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerDoesntExistsMock).Should().BeEquivalentTo(wrongValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerDoesntExistsMock).Should().BeEquivalentTo(wrongValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerDoesntExistsMock).Should().BeEquivalentTo(wrongValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber4, ContainerDoesntExistsMock).Should().BeEquivalentTo(correctValue);
        }

        [TestMethod()]
        public void DigitSNTest()
        {
            string FGSerialNumber1 = "IDN00001";
            string FGSerialNumber2 = "IDN000002";
            string FGSerialNumber3 = "IDN0003";
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DIGIT_8 };

            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerDoesntExistsMock).Should().BeEquivalentTo(correctValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber2, ContainerDoesntExistsMock).Should().BeEquivalentTo(wrongValue);
            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber3, ContainerDoesntExistsMock).Should().BeEquivalentTo(wrongValue);
        }

        [TestMethod()]
        public void IsNotExistsSNTest()
        {
            string FGSerialNumber1 = "IDN00001";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DUPLICATE_FG };

            kittingUsecase.ValidateFGSerialNumber(FGSerialNumber1, ContainerExistsMock).Should().BeEquivalentTo(wrongValue);
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