using PCI.KittingApp.Driver.SQLite;
using PCI.KittingApp.Entity.Printer;
using PCI.KittingApp.Entity.TransactionType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository.SQLite
{
    public class PrintingLabel
    {
        private ReadWriteOperation<Entity.Printer.PrintingLabel> _transactionDriver;
        public PrintingLabel(ReadWriteOperation<Entity.Printer.PrintingLabel> transactionDriver)
        {
            _transactionDriver = transactionDriver;
        }

        public void Insert(Entity.Printer.PrintingLabel entity)
        {
            _transactionDriver.Write(entity, "INSERT INTO PrintingLabel (TypeTxn, DataTxn, PathPrinter, DateTxn, IdTxn, FinishGood) VALUES (@TypeTxn, @DataTxn, @PathPrinter, @DateTxn, @IdTxn, @FinishGood)");
        }

        public List<Entity.Printer.PrintingLabel> GetPrintingLabel(string FinishGood, TypeTransaction typeTransaction)
        {
            return _transactionDriver.ReadAll($"SELECT * FROM PrintingLabel WHERE FinishGood = '{FinishGood}' AND TypeTxn = '{(int)typeTransaction}'");
        }
    }
}
