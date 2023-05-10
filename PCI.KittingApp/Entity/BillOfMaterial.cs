using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public class BillOfMaterial
    {
        public string Product { get; set; }
        public string Description { get; set; }
        public double QtyRequired { get; set; }
        public Enumeration<IssueControlEnum, int> IssueControl { get; set; }
        public bool isRegistered { get; set; }

    }
}
