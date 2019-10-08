using System;
using System.Globalization;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
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

        /// <summary>
        /// Check if it's possible to convert the value to Int32 (Floating point is automatic converted to fixed point and result true).
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidInt32(this object value, IFormatProvider provider = null) =>
            value.ToInt32Safe(provider) != null;
    }
}