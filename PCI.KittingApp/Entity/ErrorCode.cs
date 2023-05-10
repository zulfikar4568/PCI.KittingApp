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
        [Description("The characters cannot be null!")]
        ERROR_NULL = 000,
        [Description("The characters must be 8 digits!")]
        ERROR_DIGIT_8 = 100,
        [Description("The charachters must contains IDN and IDN must be capital!")]
        ERROR_IDN = 101,
        [Description("The FG already exists!")]
        ERROR_DUPLICATE_FG = 102,
        [Description("The Issue Control must be Serialized!")]
        ERROR_ISSUE_CONTROL = 103,
        [Description("The Part Number doen't exists compared to the list on the ERP BOM which are registered!")]
        ERROR_WRONG_PN = 104,
        [Description("The Part Number already registered!")]
        ERROR_PN_REGISTERED = 105,
        [Description("The Customer SN is wrong format, it's should be PN_REV_SN for example 5918748_01_IDN00002!")]
        ERROR_FORMAT_CUSTOMER_SN = 106,
        [Description("The Customer SN is miss match with FG SN!")]
        ERROR_SN_MISSMATCH = 107,
        [Description("The characters must 10 digits or upper!")]
        ERROR_DIGIT_LESS_10 = 108,


    }
    public static class Extension
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
        public static T GetEnumValueByDescription<T>(this string description) where T : Enum
        {
            foreach (Enum enumItem in Enum.GetValues(typeof(T)))
            {
                if (enumItem.GetEnumDescription() == description)
                {
                    return (T)enumItem;
                }
            }
            throw new ArgumentException("Not found.", nameof(description));
        }
    }
}
