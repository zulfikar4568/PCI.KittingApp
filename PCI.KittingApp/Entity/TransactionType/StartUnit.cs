using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.TransactionType
{
    public class StartUnit
    {
        public string ContainerName { get; set; } 
        public string MfgOrderName { get; set; }
        public ProductDefaultStart ProductDefaultStart { get; set; }
    }
}
