using System;
using System.Globalization;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast;

public static class ToInt64Extensions
{
    public static long ToInt64(this object value, IFormatProvider provider = null)
    {
        provider ??= MaestriaFluentCastSettings.Properties.NumberCulture;
        return value switch
        {
            string s when string.IsNullOrEmpty(s) => throw new ArgumentNullException(nameof(value), "Value cannot be null or empty to convert ToInt64."),
            string s when long.TryParse(s, NumberStyles.Integer, provider, out var resultInt) => resultInt,
            string s when float.TryParse(s, NumberStyles.Float, provider, out var resultFloat) => (long)resultFloat,
            float f => (long)f,
            decimal d => (long)d,
            double d => (long)d,
            _ => value.ConvertTo(v => Convert.ToInt64(v, provider))
        };
    }

    public static long? ToInt64Safe(this object value, IFormatProvider provider = null) =>
        value.ConvertToSafe(v => value.ToInt64(provider));

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