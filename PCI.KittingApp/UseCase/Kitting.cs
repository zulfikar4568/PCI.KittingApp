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
        public ValidationStatus ValidateFGSerialNumberExists(string FGSerialNumber, Func<string, bool> ValidateFGExists)
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
        public ValidationStatus ValidateFGSerialNumber(string FGSerialNumber, Func<string, bool> ValidateFGExists)
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
    }
}
