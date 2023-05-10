using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public class ValidationStatus
    {
        public bool IsSuccess { get; set; }
        public ErrorCode? ErrorCode { get; set; }
    }
}
