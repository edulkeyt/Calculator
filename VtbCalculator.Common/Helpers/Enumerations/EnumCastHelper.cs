using System;

namespace VtbCalculator.Common.Helpers.Enumerations
{
    public static class EnumCastHelper
    {
        public static bool IsValueDefined<T>(int val) where T : struct, IConvertible
        {
            return Enum.IsDefined(typeof(T), val);
        }
    }
}
