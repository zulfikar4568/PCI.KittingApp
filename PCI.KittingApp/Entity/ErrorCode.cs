using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity
{
    public enum ErrorCode
    {
        ERROR_NULL = 000,
        ERROR_DIGIT_8 = 100,
        ERROR_IDN = 101,
        ERROR_DUPLICATE_FG = 102,
        ERROR_ISSUE_CONTROL = 103,
        ERROR_WRONG_PN = 104,
        ERROR_PN_REGISTERED = 105,
        ERROR_FORMAT_CUSTOMER_SN = 106,
        ERROR_SN_MISSMATCH = 107,
        ERROR_DIGIT_LESS_10 = 108,
        ERROR_NOT_EXISTS = 109,
        ERROR_BOM_NOT_COMPLETED = 110,
        ERROR_CUSTOMER_SN_ALREADY_USED = 111,
        ERROR_UNKNOWN = 500,
    }
    public static class ErrorCodeMeaning
    {
        public static string Translate(ErrorCode? code)
        {
            string message;
            switch (code)
            {
                case ErrorCode.ERROR_NULL:
                    message = "The characters cannot be null!";
                    break;
                case ErrorCode.ERROR_DIGIT_8:
                    message = "The characters must be 8 digits!";
                    break;
                case ErrorCode.ERROR_IDN:
                    message = "The charachters must contains IDN and IDN must be capital!";
                    break;
                case ErrorCode.ERROR_DUPLICATE_FG:
                    message = "The Container / Identifier FG already exists!";
                    break;
                case ErrorCode.ERROR_ISSUE_CONTROL:
                    message = "The Issue Control must be Serialized!";
                    break;
                case ErrorCode.ERROR_WRONG_PN:
                    message = "The Part Number doen't exists compared to the list on the ERP BOM which are registered!";
                    break;
                case ErrorCode.ERROR_PN_REGISTERED:
                    message = "The Part Number already registered!";
                    break;
                case ErrorCode.ERROR_FORMAT_CUSTOMER_SN:
                    message = "The Customer SN is wrong format, it's should be PN_REV_SN for example 5918748_01_IDN00002!";
                    break;
                case ErrorCode.ERROR_SN_MISSMATCH:
                    message = "The Customer SN is miss match with FG SN!";
                    break;
                case ErrorCode.ERROR_DIGIT_LESS_10:
                    message = "The characters must 10 digits or upper!";
                    break;
                case ErrorCode.ERROR_NOT_EXISTS:
                    message = "Data is not exist!";
                    break;
                case ErrorCode.ERROR_BOM_NOT_COMPLETED:
                    message = "Please complete all BOM, before submit to MES!";
                    break;
                case ErrorCode.ERROR_CUSTOMER_SN_ALREADY_USED:
                    message = "The customer serial number already used by another Part Number, please used others customer serial number!";
                    break;
                default:
                    message = "Unknown Error";
                    break;
            }
            return message;
        }
    }
}
