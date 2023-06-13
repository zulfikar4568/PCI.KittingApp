using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.TransactionType
{
    public static class TransactionType
    {
        public static string Translate(TypeTransaction? typeTransaction)
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
                    return "Unknown";
            }
        }
    }

    public enum TypeTransaction
    {
        StartMaterial,
        StartUnit,
        CreateOrder
    }
}
