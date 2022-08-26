using System.Text;

namespace Maestria.Extensions.FluentCast
{
    public static class ToByteArrayExtensions
    {
        /// <summary>
        /// Get byte[] from string at UTF8 Encoding
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value) => Encoding.UTF8.GetBytes(value);

        /// <summary>
        /// Get byte[] from string at "encoding" param
        /// </summary>
        /// <param name="value"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this string value, Encoding encoding) => encoding.GetBytes(value);
    }
}
