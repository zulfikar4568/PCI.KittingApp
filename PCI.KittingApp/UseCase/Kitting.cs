using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.UseCase
{
    public class Kitting
    {
        public bool ValidateFGSerialNumber(string FGSerialNumber, Func<string, bool> ValidateFGExists)
        {
            // IDN00002
            // Validate 8 digit characters
            if (FGSerialNumber.Length != 8) return false;
            // Validate IDN must be capitals letters
            if (!FGSerialNumber.Contains("IDN")) return false;
            // Validate if FG Serial Number already exists
            return ValidateFGExists(FGSerialNumber);
        }
    }
}
