using System;
using System.Globalization;

namespace FluentCast
{
    public static class ToDateTimeExtensions
    {
        public static DateTime ToDateTime(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDateTime(v, provider ?? CultureInfo.InvariantCulture));

        public static DateTime? ToDateTimeSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDateTime(value, provider ?? CultureInfo.InvariantCulture));

        public static DateTime ToDateTimeSafe(this object value, DateTime @default, IFormatProvider provider = null) =>
            value.ToDateTimeSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;
    }
}