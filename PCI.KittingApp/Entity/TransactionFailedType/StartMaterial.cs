using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.TransactionFailedType
{
    public class StartMaterial
    {
        public string SerialNumberReference { get; set; }
        public string Product { get; set; }
        public string BatchID { get; set; }
        public string CustomerSerialNumber { get; set; }
        public ProductDefaultStart ProductDefaultStart { get; set; }
    }
}
