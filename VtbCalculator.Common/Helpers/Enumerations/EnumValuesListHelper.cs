using System;
using System.Collections.Generic;
using System.Linq;

namespace VtbCalculator.Common.Helpers.Enumerations
{
    public static class EnumValuesListHelper
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}