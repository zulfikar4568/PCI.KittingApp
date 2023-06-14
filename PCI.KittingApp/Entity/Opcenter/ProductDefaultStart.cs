using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public class ProductDefaultStart
    {
        public string StartLevel { get; set; }
        public string StartOwner { get; set; }
        public string StartReason { get; set; }
        public double StartQty { get; set; }
        public string StartUOM { get; set; }
        public string Workflow { get; set; }
        public string PathPrinter { get; set; }
    }
}