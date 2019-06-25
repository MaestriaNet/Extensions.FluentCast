using System;

namespace FluentCast
{
    public static class ConvertExtensions
    {
        #region Generic data type conversion

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

        #endregion
    }
}