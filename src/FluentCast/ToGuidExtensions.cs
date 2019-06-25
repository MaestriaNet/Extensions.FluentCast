using System;

namespace FluentCast
{
    public static class ToGuidExtensions
    {
        public static Guid ToGuid(this string value) => value.ConvertTo(v => Guid.Parse((string) v));

        public static Guid? ToGuidSafe(this string value) => value.ConvertToSafe(v => Guid.Parse((string) v));
    }
}