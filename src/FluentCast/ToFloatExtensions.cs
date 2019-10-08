using System;
using System.Globalization;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
{
    public static class ToFloatExtensions
    {
        public static float ToFloat(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToSingle(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static float? ToFloatSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToSingle(value, provider ?? GlobalSettings.Properties.NumberCulture));

        public static float ToFloatSafe(this object value, float @default, IFormatProvider provider = null) =>
            value.ToFloatSafe(provider) ?? @default;

        public static bool IsValidFloat(this object value, IFormatProvider provider = null) =>
            value.ToFloatSafe(provider) != null;
    }
}