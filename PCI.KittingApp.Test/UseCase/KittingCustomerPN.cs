using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingCustomerPN
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();
        [TestMethod]
        public void WrongPN()
        {
            string partNumberActual = "5920748";
            string partNumberBOM = "GH591874800";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_MISSMATCH };

            kittingUsecase.ValidateIfPNMatch(partNumberBOM, partNumberActual).Should().BeEquivalentTo(wrongValue);
        }
        [TestMethod]
        public void CorrectPN()
        {
            string partNumberActual = "5918748";
            string partNumberBOM = "GH591874800";
            var correctValue = new ValidationStatus() { IsSuccess = true, ErrorCode = null };

            kittingUsecase.ValidateIfPNMatch(partNumberBOM, partNumberActual).Should().BeEquivalentTo(correctValue);
        }
    }
}
