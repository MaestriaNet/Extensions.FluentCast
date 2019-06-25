using System;
using System.Globalization;

namespace FluentCast
{
    public static class ToFloatExtensions
    {
        public static float ToFloat(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToSingle(value, provider ?? CultureInfo.InvariantCulture));

        public static float? ToFloatSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToSingle(value, provider ?? CultureInfo.InvariantCulture));

        public static float ToFloatSafe(this object value, float @default, IFormatProvider provider = null) =>
            value.ToFloatSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;
    }
}