using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Maestria.Extensions.FluentCast.Test")]
namespace Maestria.Extensions.FluentCast.Internal;

internal static class ConvertExtensions
{
    /// <summary>
    /// Unsafe convert data.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="convertFunction"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T ConvertTo<T>(this object value, Func<object, T> convertFunction)
    {
        if (value is T @out)
            return @out;
        return convertFunction(value);
    }

    /// <summary>
    /// Try to convert value, when throw exception returns null value.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="convertFunction"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T? ConvertToSafe<T>(this object value, Func<object, T> convertFunction)
        where T : struct
    {
        try
        {
            return value switch
            {
                null => null,
                string str when string.IsNullOrWhiteSpace(str) => null,
                T result => result,
                _ => value.ConvertTo(convertFunction)
            };
        }
        catch
        {
            return null;
        }
    }
}