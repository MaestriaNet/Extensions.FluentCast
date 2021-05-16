namespace Maestria.FluentCast
{
    public static class CastExtensions
    {
        /// <summary>
        /// Safe cast "value as T"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T CastAs<T>(this object value) where T : class => value as T;

        /// <summary>
        /// Unsafe cast "(T)value"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T CastTo<T>(this object value) => (T)value;
    }
}