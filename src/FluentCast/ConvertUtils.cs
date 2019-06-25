using System;
using System.Globalization;

namespace FluentCast
{
    public static class ConvertUtils
    {
        #region Generic data type conversion

        private static T ConvertTo<T>(this object value, Func<object, T> transform)
        {
            if (value is T @out) return @out;
            return transform(value);
        }

        private static T? ConvertToSafe<T>(this object value, Func<object, T> transform)
            where T : struct
        {
            try
            {
                switch (value)
                {
                    case null: return null;
                    case string str when string.IsNullOrWhiteSpace(str): return null;
                    default: return value.ConvertTo(transform);
                }
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Int16 (Short)

        public static short ToInt16(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt16(value, provider ?? CultureInfo.InvariantCulture));

        public static short? ToInt16Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToInt16(value, provider ?? CultureInfo.InvariantCulture));

        public static short ToInt16Safe(this object value, short @default, IFormatProvider provider = null) =>
            value.ToInt16Safe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Int32 (Int)

        public static int ToInt32(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt32(value, provider ?? CultureInfo.InvariantCulture));

        public static int? ToInt32Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToInt32(value, provider ?? CultureInfo.InvariantCulture));

        public static int ToInt32Safe(this object value, int @default, IFormatProvider provider = null) =>
            value.ToInt32Safe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Int64 (Long)

        public static long ToInt64(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToInt64(value, provider ?? CultureInfo.InvariantCulture));

        public static long? ToInt64Safe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToInt64(value, provider ?? CultureInfo.InvariantCulture));

        public static long ToInt64Safe(this object value, long @default, IFormatProvider provider = null) =>
            value.ToInt64Safe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Decimal

        public static decimal ToDecimal(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDecimal(value, provider ?? CultureInfo.InvariantCulture));

        public static decimal? ToDecimalSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDecimal(value, provider ?? CultureInfo.InvariantCulture));

        public static decimal ToDecimalSafe(this object value, decimal @default, IFormatProvider provider = null) =>
            value.ToDecimalSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Float (Single)

        public static float ToFloat(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToSingle(value, provider ?? CultureInfo.InvariantCulture));

        public static float? ToFloatSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToSingle(value, provider ?? CultureInfo.InvariantCulture));

        public static float ToFloatSafe(this object value, float @default, IFormatProvider provider = null) =>
            value.ToFloatSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Double

        public static double ToDouble(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDouble(value, provider ?? CultureInfo.InvariantCulture));

        public static double? ToDoubleSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDouble(value, provider ?? CultureInfo.InvariantCulture));

        public static double ToDoubleSafe(this object value, double @default, IFormatProvider provider = null) =>
            value.ToDoubleSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region DateTime

        public static DateTime ToDateTime(this object value, IFormatProvider provider = null) =>
            value.ConvertTo(v => Convert.ToDateTime(v, provider ?? CultureInfo.InvariantCulture));

        public static DateTime? ToDateTimeSafe(this object value, IFormatProvider provider = null) =>
            value.ConvertToSafe(v => Convert.ToDateTime(value, provider ?? CultureInfo.InvariantCulture));

        public static DateTime ToDateTimeSafe(this object value, DateTime @default, IFormatProvider provider = null) =>
            value.ToDateTimeSafe(provider ?? CultureInfo.InvariantCulture) ?? @default;

        #endregion

        #region Guid

        public static Guid ToGuid(this string value) => value.ConvertTo(v => Guid.Parse((string) v));

        public static Guid? ToGuidSafe(this string value) => value.ConvertToSafe(v => Guid.Parse((string) v));

        #endregion

        #region String

        /// <summary>
        /// Convert to string safe. Returning null when error occur
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringSafe(this object value)
        {
            try
            {
                return value?.ToString();
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}