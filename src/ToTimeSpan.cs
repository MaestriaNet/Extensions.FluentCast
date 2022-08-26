using System;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast
{
    public static class ToTimeSpanExtensions
    {
        private static TimeSpan Convert(object value, IFormatProvider provider)
        {
            if (value is TimeSpan timeSpan) 
                return timeSpan;
            return TimeSpan.Parse(value.ToString(), provider);
        }
        
        public static TimeSpan ToTimeSpan(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert(v, provider ?? GlobalSettings.Properties.DateTimeCulture));

        public static TimeSpan? ToTimeSpanSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert(value, provider ?? GlobalSettings.Properties.DateTimeCulture));

        public static TimeSpan ToTimeSpanSafe(this object value, TimeSpan @default, IFormatProvider provider = null) =>
            value.ToTimeSpanSafe(provider) ?? @default;

        public static bool IsValidTimeSpan(this object value, IFormatProvider provider = null) =>
            value.ToTimeSpanSafe(provider) != null;
    }
}