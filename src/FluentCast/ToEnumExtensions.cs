using System;

namespace FluentCast
{
    public static class ToEnumExtensions
    {
        public static T ToEnum<T>(this object value) where T : struct
        {
            if (value == null)
                throw new ArgumentNullException("Null value not supported to convert to enum.");

            if (value is T result) return result;

            var enumType = typeof(T);

            if (value is char)
                return (T) Enum.ToObject(typeof(T), Convert.ToChar(value));

            if (value is byte || value is int || value is sbyte)
                return (T) Enum.ToObject(typeof(T), Convert.ToByte(value));

            var enumValue = Enum.Parse(enumType, value.ToString());
            return (T) enumValue;
        }

        public static T? ToEnumSafe<T>(this object value) where T : struct
        {
            try
            {
                return ToEnum<T>(value);
            }
            catch
            {
                return null;
            }
        }

        public static T ToEnumSafe<T>(this object value, T @default) where T : struct
        {
            return ToEnumSafe<T>(value) ?? @default;
        }
    }
}