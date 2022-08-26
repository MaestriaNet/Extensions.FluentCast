using System;
using System.Globalization;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast
{
    public static class ToDecimalExtensions
    {
        public static decimal ToDecimal(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDecimal(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static decimal? ToDecimalSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDecimal(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static decimal ToDecimalSafe(this object value, decimal @default, IFormatProvider provider = null) =>
            value.ToDecimalSafe(provider) ?? @default;

        public static bool IsValidDecimal(this object value, IFormatProvider provider = null) =>
            value.ToDecimalSafe(provider) != null;
    }
}