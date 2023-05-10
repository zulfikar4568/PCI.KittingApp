using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Entity;
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

        public bool ValidatePNAssociatedWithERPBOM(string PartNumber, ref BillOfMaterial[] BOMs)
        {
            bool result = false;

            for (int i = 0; i < BOMs.Length; i++)
            {
                if (BOMs[i] == null) continue;
                // If Type is not serialized
                if (BOMs[i].IssueControl != IssueControlEnum.Serialized) continue;
                // Check if PartNumber is same and not yet registered
                if (BOMs[i].Product == PartNumber && !BOMs[i].isRegistered)
                {
                    BOMs[i].isRegistered = true;
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
