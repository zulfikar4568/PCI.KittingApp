using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.TransactionType
{
    public class CreateOrder
    {
        public string MfgOrderName { get; set; }
        public string ProductName { get; set; }
        public string Qty { get; set; }
        public string UOM { get; set; }
    }
}
