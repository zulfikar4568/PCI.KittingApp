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
        public ValidationStatus ValidateIfPNMatch(string partNumberBOM, string partNumberActual)
        {
            // Validate if PN is contained
            if (partNumberActual == "" || partNumberActual is null || !partNumberBOM.ToUpper().Contains(partNumberActual.ToUpper())) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_MISSMATCH};
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }
        // Will error if FG SN not exists!
        public ValidationStatus ValidateFGSerialNumberCheckIfExists(string FGSerialNumber, Func<string, bool> ValidateFGExists)
        {
            // IDN00002
            // Validate 8 digit characters
            if (FGSerialNumber.Length != 8) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DIGIT_8 };
            // Validate IDN must be capitals letters
            if (!FGSerialNumber.Contains("IDN")) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_IDN };
            // Validate if FG Serial Number not yet exists
            if (!ValidateFGExists(FGSerialNumber)) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_NOT_EXISTS };
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };

        }
        // Will error if FG SN already exists!
        public ValidationStatus ValidateFGSerialNumberCheckIfNotDuplicate(string FGSerialNumber, Func<string, bool> ValidateFGExists)
        {
            // IDN00002
            // Validate 8 digit characters
            if (FGSerialNumber.Length != 8) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DIGIT_8 };
            // Validate IDN must be capitals letters
            if (!FGSerialNumber.Contains("IDN")) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_IDN };
            // Validate if FG Serial Number is already exists
            if (ValidateFGExists(FGSerialNumber)) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DUPLICATE_FG };
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };

        }
        public ValidationStatus CheckIfCustomerSNAlreadyUsedInBOM(BillOfMaterial[] BOMs, string CustomerSerialNumber)
        {
            foreach (var item in BOMs)
            {
                if (item.CustomerSerialNumber == null) continue;
                if (CustomerSerialNumber == item.CustomerSerialNumber) return new ValidationStatus() { ErrorCode = ErrorCode.ERROR_CUSTOMER_SN_ALREADY_USED, IsSuccess = false };
            }
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }
        public ValidationStatus CheckIfBOMAllRegistered(BillOfMaterial[] BOMs)
        {
            if (BOMs == null) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_NULL };

            foreach (var item in BOMs)
            {
                if (!item.isRegistered) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_BOM_NOT_COMPLETED };
            }
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }
        public ValidationStatus ValidatePNAssociatedWithERPBOM(string PartNumber, BillOfMaterial[] BOMs)
        {
            // By default Part number define not same with on the ERP BOM
            ValidationStatus result = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_WRONG_PN };

            for (int i = 0; i < BOMs.Length; i++)
            {
                if (BOMs[i] == null) continue;
                if (BOMs[i].Product == PartNumber && BOMs[i].IssueControl == IssueControlEnum.Serialized && !BOMs[i].isRegistered)
                {
                    result = new ValidationStatus() { IsSuccess = true, ErrorCode = null };
                    break;
                }

                // If Type is not serialized
                if (BOMs[i].Product == PartNumber && BOMs[i].IssueControl != IssueControlEnum.Serialized && !BOMs[i].isRegistered)
                {
                    result = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_ISSUE_CONTROL };
                    break;
                }

                // if BOM registered
                if (BOMs[i].Product == PartNumber && BOMs[i].IssueControl == IssueControlEnum.Serialized && BOMs[i].isRegistered)
                {
                    result = new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_REGISTERED };
                    break;
                }
            }

            return result;
        }

        public ValidationStatus ValidateCustomerSerialNumber(string CustomerSerialNumber)
        {
            if (CustomerSerialNumber == null) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_NULL };
            var data = CustomerSerialNumber.Split('_');
            if (data.Length != 3) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_FORMAT_CUSTOMER_SN };
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }

        public ValidationStatus ValidateCustomerSerialNumber(string CustomerSerialNumber, string FGSerialNumber)
        {
            if (CustomerSerialNumber == null) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_NULL };
            var data = CustomerSerialNumber.Split('_');
            if (data.Length != 3) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_FORMAT_CUSTOMER_SN };
            if (FGSerialNumber != data[2]) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_SN_MISSMATCH };
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }

        public ValidationStatus ValidateBatchID(string BatchID)
        {
            if (BatchID == null) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_NULL };
            if (BatchID.Length < 10) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_DIGIT_LESS_10 };
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }

        public ValidationStatus ValidateCustomerSerialNumberWithoutDelimiter(string CustomerSerialNumberWithoutDelimiter, string InternalPCIPartNumber, string FGSerialNumber)
        {
            if (!CustomerSerialNumberWithoutDelimiter.Contains(FGSerialNumber)) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_SN_MISSMATCH };
            
            var removeFGSN = CustomerSerialNumberWithoutDelimiter.Replace(FGSerialNumber, "");
            var actualPartNumber = removeFGSN.Substring(0, removeFGSN.Length - 2);
            if (!InternalPCIPartNumber.Contains(actualPartNumber)) return new ValidationStatus() { IsSuccess = false, ErrorCode = ErrorCode.ERROR_PN_MISSMATCH};
            return new ValidationStatus() { IsSuccess = true, ErrorCode = null };
        }
    }
}
