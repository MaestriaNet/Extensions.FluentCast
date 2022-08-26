using System;
using System.Globalization;

namespace Maestria.Extensions.FluentCast
{
    public static class NumberExtensions
    {
        /// <summary>
        /// Check if string is a valid fixed point value. When string is a floating point the result is false.
        /// Cehck another functions to allow automatic conversion from floating point: <see cref="ToInt16Extensions.IsValidInt16"/>, <see cref="ToInt32Extensions.IsValidInt32"/> or <see cref="ToInt64Extensions.IsValidInt64"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidInteger(this string value, IFormatProvider provider = null) =>
            long.TryParse(value, NumberStyles.Integer, provider ?? GlobalSettings.Properties.NumberCulture, out _);

        /// <summary>
        /// Check if string is a valid floating point value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidFloatingPoint(this string value, IFormatProvider provider = null) =>
            decimal.TryParse(value, NumberStyles.Float, provider ?? GlobalSettings.Properties.NumberCulture, out _);

        /// <summary>
        /// Check if string is a valid currency value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool IsValidCurrency(this string value, IFormatProvider provider = null) =>
            decimal.TryParse(value, NumberStyles.Currency, provider ?? GlobalSettings.Properties.NumberCulture, out _);
    }
}