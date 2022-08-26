using System.Globalization;

namespace Maestria.Extensions.FluentCast.Settings
{
    public class FluentCastSettings
    {
        public CultureInfo NumberCulture { get; set; } = CultureInfo.InvariantCulture;
        public CultureInfo DateTimeCulture { get; set; } = CultureInfo.InvariantCulture;
    }
}