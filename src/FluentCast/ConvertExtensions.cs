using System;

namespace FluentCast
{
    public static class ConvertExtensions
    {
        public static T ConvertTo<T>(this object value, Func<object, T> changeFunction)
        {
            if (value is T @out) return @out;
            return changeFunction(value);
        }

        public static T? ConvertToSafe<T>(this object value, Func<object, T> changeFunction)
            where T : struct
        {
            try
            {
                switch (value)
                {
                    case null: return null;
                    case string str when string.IsNullOrWhiteSpace(str): return null;
                    default: return value.ConvertTo(changeFunction);
                }
            }
            catch
            {
                return null;
            }
        }


        /*public static T ConvertToSafe<T>(this object value, Func<object, T> changeFunction, T @default)
        {
            try
            {
                switch (value)
                {
                    case null: return @default;
                    case string str when string.IsNullOrWhiteSpace(str): return @default;
                    default: return value.ConvertTo(changeFunction);
                }
            }
            catch
            {
                return @default;
            }
        }*/
    }
}