using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public class MaterialRegistration
    {
        public string ProductName { get; set; }
        public string ERPBOMName { get; set; }
        public BillOfMaterial[] BillOfMaterial { get; set; }
    }
}
