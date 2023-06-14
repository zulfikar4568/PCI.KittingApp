using PCI.KittingApp.Entity.Printer;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PCI.KittingApp.UseCase
{
    public class PrintingLabelUseCase
    {
        private Repository.SQLite.PrintingLabel _repositoryPrintingLabel;
        public PrintingLabelUseCase(Repository.SQLite.PrintingLabel repositoryPrintingLabel)
        {
            _repositoryPrintingLabel = repositoryPrintingLabel;
        }
        public void StartPrintingLabel(PrintingLabel Data)
        {
            bool result = FileUtil.GenerateLabel(Data.PathPrinter, "KittingApp", TransactionType.Translate(Data.TypeTxn), Data.DataTxn);
            if (result) _repositoryPrintingLabel.Insert(Data);
        }

        public PrintingLabel GenerateDataFromStartUnit(StartUnit startUnit, string IdTxn)
        {
            return new PrintingLabel()
            {
                TypeTxn = TypeTransaction.StartUnit,
                DataTxn = startUnit.ContainerName,
                DateTxn = DateTime.Now,
                PathPrinter = startUnit.ProductDefaultStart.PathPrinter,
                FinishGood = startUnit.ContainerName,
                IdTxn = IdTxn,
            };
        }

        public PrintingLabel GenerateDataFromStartMaterial(StartMaterial startMaterial, string IdTxn)
        {
            return new PrintingLabel()
            {
                TypeTxn = TypeTransaction.StartMaterial,
                DataTxn = startMaterial.CustomerSerialNumber,
                DateTxn = DateTime.Now,
                PathPrinter = startMaterial.ProductDefaultStart.PathPrinter,
                FinishGood = startMaterial.SerialNumberReference,
                IdTxn = IdTxn,
            };
        }

        public List<PrintingLabel> GetUnitPrintingLabel(string ContainerName)
        {
            return _repositoryPrintingLabel.GetPrintingLabel(ContainerName, TypeTransaction.StartUnit);
        }

        public List<PrintingLabel> GetMaterialPrintingLabel(string ContainerName)
        {
            return _repositoryPrintingLabel.GetPrintingLabel(ContainerName, TypeTransaction.StartMaterial);
        }
    }
}
  