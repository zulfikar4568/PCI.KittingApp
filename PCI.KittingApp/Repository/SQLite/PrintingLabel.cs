using PCI.KittingApp.Driver.SQLite;
using PCI.KittingApp.Entity.Printer;
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

        public Entity.Printer.PrintingLabel ReadLastPrintedByTypeTxn(string TypeTxn)
        {
            return _transactionDriver.Read($"SELECT * FROM PrintingLabel WHERE TypeTxn = '{TypeTxn}' ORDER BY date(DateTxn) DESC LIMIT 1;");
        }
    }
}
