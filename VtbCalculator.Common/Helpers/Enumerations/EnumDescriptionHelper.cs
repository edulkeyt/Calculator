using System;
using System.ComponentModel;

namespace VtbCalculator.Common.Helpers.Enumerations
{
    public static class EnumDescriptionHelper
    {
        private static string GetDescriptionInternal(object value, Type t)
        {
            if (t == null) t = value.GetType();
            var attributes = (DescriptionAttribute[]) t.GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : Enum.GetName(t, value);
        }

        public static string GetDescription(this Enum enumObj)
        {
            return GetDescriptionInternal(enumObj, enumObj.GetType());
        }
    }
}