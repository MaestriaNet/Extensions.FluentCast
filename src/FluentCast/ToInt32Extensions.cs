using System;
using FluentCast.Internal;

namespace FluentCast
{
    public static class ToInt32Extensions
    {
        public static int ToInt32(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt32(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static int? ToInt32Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v =>
                Convert.ToInt32(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static int ToInt32Safe(this object value, int @default, IFormatProvider provider = null) =>
            value.ToInt32Safe(provider) ?? @default;
    }
}