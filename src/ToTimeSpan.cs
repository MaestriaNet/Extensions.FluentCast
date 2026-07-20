using System;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast;

public static class ToTimeSpanExtensions
{
    public static TimeSpan ToTimeSpan(this object value, IFormatProvider provider = null) =>
        value.ConvertTo(v => TimeSpan.Parse(v.ToString()!, provider ?? MaestriaFluentCastSettings.Properties.DateTimeCulture));

    public static TimeSpan? ToTimeSpanSafe(this object value, IFormatProvider provider = null) =>
        value.ConvertToSafe(v => TimeSpan.Parse(value.ToString()!, provider ?? MaestriaFluentCastSettings.Properties.DateTimeCulture));

    public static TimeSpan ToTimeSpanSafe(this object value, TimeSpan @default, IFormatProvider provider = null) =>
        value.ToTimeSpanSafe(provider) ?? @default;

    public static bool IsValidTimeSpan(this object value, IFormatProvider provider = null) =>
        value.ToTimeSpanSafe(provider) != null;
}