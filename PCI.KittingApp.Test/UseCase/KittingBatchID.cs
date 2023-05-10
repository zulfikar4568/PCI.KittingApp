using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(true, kittingUsecase.ValidateBatchID(batchID));
        }

        [TestMethod]
        public void LessBatchID()
        {

            string batchID = "000746";
            Assert.AreEqual(false, kittingUsecase.ValidateBatchID(batchID));
        }
    }
}
