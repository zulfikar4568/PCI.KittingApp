using PCI.KittingApp.Config;
using PCI.KittingApp.Entity.Printer;
using PCI.KittingApp.Entity.TransactionType;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void StartPrintingLabel(PrintingLabel Data, bool IsSavedToDB)
        {
            // Generate File if IsPrintingFileEnabled settings enabled
            if (AppSettings.IsPrintingFileEnabled) FileUtil.GenerateLabel(Data.PathPrinter, "KittingApp", TransactionType.Translate(Data.TypeTxn), Data.DataTxn);

            // Send Data to Printer if IsPrintingDeviceEnabled settings enabled
            if (AppSettings.IsPrintingDeviceEnabled) SendDataToPrinter(Data);

            // Save Data to DB, and later will re-perform the printing label
            if (IsSavedToDB) _repositoryPrintingLabel.Insert(Data);
        }

        public bool SendDataToPrinter(PrintingLabel Data)
        {
            try
            {
                bool result = RawPrinterUtil.SendStringToPrinter(AppSettings.PrinterName, Data.DataTxn);
                if (result) EventLogUtil.LogEvent($"Print Label {Data.DataTxn} using {AppSettings.PrinterName} success!", System.Diagnostics.EventLogEntryType.Information, 6);
                return result;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                return false;
            }
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
  