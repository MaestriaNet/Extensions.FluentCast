namespace FluentCast
{
    public static class ToStringExtensions
    {
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
    }
}