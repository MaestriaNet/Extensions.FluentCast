using System;
using System.Globalization;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast;

public static class ToInt16Extensions
{
    public static short ToInt16(this object value, IFormatProvider provider = null)
    {
        provider ??= MaestriaFluentCastSettings.Properties.NumberCulture;
        return value switch
        {
            string s when string.IsNullOrEmpty(s) => throw new ArgumentNullException(nameof(value), "Value cannot be null or empty to convert ToInt16."),
            string s when short.TryParse(s, NumberStyles.Integer, provider, out var resultInt) => resultInt,
            string s when float.TryParse(s, NumberStyles.Float, provider, out var resultFloat) => (short)resultFloat,
            float f => (short)f,
            decimal d => (short)d,
            double d => (short)d,
            _ => value.ConvertTo(v => Convert.ToInt16(v, provider))
        };
    }

    public static short? ToInt16Safe(this object value, IFormatProvider provider = null) =>
        value.ConvertToSafe(v => value.ToInt16(provider));

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