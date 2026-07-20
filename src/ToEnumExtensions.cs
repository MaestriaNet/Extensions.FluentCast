using System;
using Maestria.Extensions.FluentCast.Internal;

namespace Maestria.Extensions.FluentCast;

public static class ToEnumExtensions
{
    public static T ToEnum<T>(this object value) where T : struct => value switch
    {
        null => throw new ArgumentNullException(nameof(value), "Null value not supported to convert to enum."),
        T result => result,
        char => (T)Enum.ToObject(typeof(T), Convert.ToChar(value)),
        byte or int or sbyte => (T)Enum.ToObject(typeof(T), Convert.ToByte(value)),
        _ => (T)Enum.Parse(typeof(T), value.ToString()!)
    };

    public static T? ToEnumSafe<T>(this object value) where T : struct => value.ConvertToSafe(v => v.ToEnum<T>());

    public static T ToEnumSafe<T>(this object value, T @default) where T : struct => value.ToEnumSafe<T>() ?? @default;

    public static bool IsValidEnum<T>(this object value) where T : struct =>
        value.ToEnumSafe<T>() != null;
}