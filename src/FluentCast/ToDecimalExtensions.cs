using System;
using System.Globalization;

namespace FluentCast
{
    public static class ToDecimalExtensions
    {
        public static decimal ToDecimal(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDecimal(value, provider ?? CultureInfo.InvariantCulture));

        public static decimal? ToDecimalSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDecimal(value, provider ?? CultureInfo.InvariantCulture));

        public static decimal ToDecimalSafe(this object value, decimal @default, IFormatProvider provider = null) =>
            value.ToDecimalSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;
    }
}