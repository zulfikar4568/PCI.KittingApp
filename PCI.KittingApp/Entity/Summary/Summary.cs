using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.Summary
{
    public class SummaryUnit
    {
        public string VersanaSN { get; set; }
        public string KittingEmployee { get; set; }
    }
    public class SummaryMaterial
    {
        public string VersanaSN { get; set; }
        public string MaterialPN { get; set; }
        public string CustomerSN { get; set; }
        public string KittingEmployee { get; set; }
    }

    public class ContainerAttributes
    {
        public string ContainerName { get; set; }
        public MaterialRegistration MaterialRegistration { get; set; }
        public ContainerAttrDetail[] ContainerAttrDetails { get; set; }
    }
    public class SummaryDataTable
    {
        public DataTable DataSummaryUnit { get; set; }
        public DataTable DataSummaryMaterial { get; set; }
    }
}
