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

        public static string TranslateTypeTransaction(TypeTransaction? typeTransaction)
        {
            switch (typeTransaction)
            {
                case TypeTransaction.StartMaterial:
                    return "StartMaterial";
                case TypeTransaction.StartUnit:
                    return "StartUnit";
                case TypeTransaction.CreateOrder:
                    return "CreateOrder";
                default:
                    return "Any";
            }
        }
    }

    public enum TypeTransaction
    {
        StartMaterial,
        StartUnit,
        CreateOrder,
        Any
    }
}
