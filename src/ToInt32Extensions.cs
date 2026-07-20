using System;
using System.Globalization;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast;

public static class ToInt32Extensions
{
    public static int ToInt32(this object value, IFormatProvider provider = null)
    {
        provider ??= MaestriaFluentCastSettings.Properties.NumberCulture;
        return value switch
        {
            string s when string.IsNullOrEmpty(s) => throw new ArgumentNullException(nameof(value), "Value cannot be null or empty to convert ToInt32."),
            string s when int.TryParse(s, NumberStyles.Integer, provider, out var resultInt) => resultInt,
            string s when float.TryParse(s, NumberStyles.Float, provider, out var resultFloat) => (int)resultFloat,
            float f => (int)f,
            decimal d => (int)d,
            double d => (int)d,
            _ => value.ConvertTo(v => Convert.ToInt32(v, provider))
        };
    }

    public static int? ToInt32Safe(this object value, IFormatProvider provider = null) =>
        value.ConvertToSafe(v => value.ToInt32(provider));

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