using System;

namespace FluentCast
{
    public static class ToInt64Extensions
    {
        public static long ToInt64(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt64(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static long? ToInt64Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v =>
                Convert.ToInt64(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static long ToInt64Safe(this object value, long @default, IFormatProvider provider = null) =>
            value.ToInt64Safe(provider) ?? @default;
    }
}