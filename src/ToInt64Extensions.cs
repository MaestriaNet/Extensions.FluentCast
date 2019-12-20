using System;
using System.Globalization;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
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

        /// <summary>
        /// Check if it's possible to convert the value to Int64 (Floating point is automatic converted to fixed point and result true).
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidInt64(this object value, IFormatProvider provider = null) =>
            value.ToInt64Safe(provider) != null;
    }
}