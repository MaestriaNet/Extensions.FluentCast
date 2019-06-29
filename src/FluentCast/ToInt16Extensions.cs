using System;

namespace FluentCast
{
    public static class ToInt16Extensions
    {
        public static short ToInt16(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt16(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static short? ToInt16Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v =>
                Convert.ToInt16(value.ToFloat(), provider ?? GlobalSettings.Properties.NumberCulture));

        public static short ToInt16Safe(this object value, short @default, IFormatProvider provider = null) =>
            value.ToInt16Safe(provider) ?? @default;
    }
}