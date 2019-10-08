using System;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
{
    public static class ToGuidExtensions
    {
        public static Guid ToGuid(this string value) => value.ConvertTo(v => Guid.Parse((string) v));

        public static Guid? ToGuidSafe(this string value) => value.ConvertToSafe(v => Guid.Parse((string) v));

        public static bool IsValidGuid(this string value, IFormatProvider provider = null) =>
            Guid.TryParse(value, out _);
    }
}