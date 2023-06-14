using PCI.KittingApp.Entity.TransactionType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.Printer
{
    public class PrintingLabel
    {
        public string Id { get; set; }
        public TypeTransaction TypeTxn { get; set; }
        public string DataTxn { get; set; }
        public string PathPrinter { get; set; }
        public DateTime? DateTxn { get; set; }
        public string IdTxn { get; set; }
        public string FinishGood { get; set; }
    }
}
