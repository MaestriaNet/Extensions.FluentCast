using System;
using Maestria.FluentCast.Internal;

namespace Maestria.FluentCast
{
    public static class ToBooleanExtensions
    {
        public static bool ToBoolean(this object value) => value.ConvertTo(Convert.ToBoolean);

        public static bool? ToBooleanSafe(this object value) => value.ConvertToSafe(v => Convert.ToBoolean(value));

        public static bool ToBooleanSafe(this object value, bool @default) => value.ToBooleanSafe() ?? @default;

        public static bool IsValidBoolean(this object value) => value.ToBooleanSafe() != null;
    }
}