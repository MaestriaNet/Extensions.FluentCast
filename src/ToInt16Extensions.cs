using System;
using System.Globalization;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
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

        /// <summary>
        /// Check if it's possible to convert the value to Int16 (Floating point is automatic converted to fixed point and result true).
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidInt16(this object value, IFormatProvider provider = null) =>
            value.ToInt16Safe(provider) != null;
    }
}