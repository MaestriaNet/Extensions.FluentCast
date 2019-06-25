using System;
using System.Globalization;

namespace FluentCast
{
    public static class ToDoubleExtensions
    {
        public static double ToDouble(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDouble(value, provider ?? CultureInfo.InvariantCulture));

        public static double? ToDoubleSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDouble(value, provider ?? CultureInfo.InvariantCulture));

        public static double ToDoubleSafe(this object value, double @default, IFormatProvider provider = null) =>
            value.ToDoubleSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;
    }
}