using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Maestria.FluentCast.Test")]
namespace Maestria.FluentCast.Internal
{
    internal static class ConvertExtensions
    {
        /// <summary>
        /// Unsafe convert data
        /// </summary>
        /// <param name="value"></param>
        /// <param name="convertFunction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ConvertTo<T>(this object value, Func<object, T> convertFunction)
        {
            if (value is T @out) return @out;
            return convertFunction(value);
        }

        /// <summary>
        /// Try convert value, when throw exception returns null value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="convertFuncion"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T? ConvertToSafe<T>(this object value, Func<object, T> convertFuncion)
            where T : struct
        {
            try
            {
                switch (value)
                {
                    case null: return null;
                    case string str when string.IsNullOrWhiteSpace(str): return null;
                    default: return value.ConvertTo(convertFuncion);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}