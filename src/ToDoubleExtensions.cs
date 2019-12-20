using System;
using System.Globalization;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
{
    public static class ToDoubleExtensions
    {
        public static double ToDouble(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDouble(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static double? ToDoubleSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDouble(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static double ToDoubleSafe(this object value, double @default, IFormatProvider provider = null) =>
            value.ToDoubleSafe(provider) ?? @default;

        public static bool IsValidDouble(this object value, IFormatProvider provider = null) =>
            value.ToDoubleSafe(provider) != null;
    }
}