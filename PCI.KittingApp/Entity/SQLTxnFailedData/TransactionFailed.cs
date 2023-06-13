using PCI.KittingApp.Entity.TransactionType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public class TransactionFailed
    {
       public string Id { get; set; }
       public TypeTransaction TypeTransaction { get; set; }
       public string DataTransaction { get; set; }
       public DateTime? DateTransaction { get; set; }
    }
}
