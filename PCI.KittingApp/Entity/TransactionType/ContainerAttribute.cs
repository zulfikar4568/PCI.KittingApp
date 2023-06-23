using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.TransactionType
{
    public class ContainerAttribute
    {
        public string ContainerName { get; set; }
        public List<ContainerAttrDetail> ContainerAttrDetails { get; set; }
    }
}
