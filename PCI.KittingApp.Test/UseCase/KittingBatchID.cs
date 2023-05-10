using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCI.KittingApp.Entity;
using System;

namespace PCI.KittingApp.Test
{
    [TestClass]
    public class KittingBatchID
    {
        private UseCase.Kitting kittingUsecase = new UseCase.Kitting();
        [TestMethod]
        public void CorrectBatchID()
        {
            string batchID = "0007405096";
            var correctValue = new ValidationStatus() { IsSuccess= true, ErrorCode = null };
            
            kittingUsecase.ValidateBatchID(batchID).Should().BeEquivalentTo(correctValue);
        }

        [TestMethod]
        public void LessBatchID()
        {

            string batchID = "000746";
            var wrongValue = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DIGIT_LESS_10 };

            kittingUsecase.ValidateBatchID(batchID).Should().BeEquivalentTo(wrongValue);
        }
    }
}
