using System.Globalization;

namespace Maestria.FluentCast.Settings
{
    public class FluentCastSettings
    {
        public CultureInfo NumberCulture { get; set; } = CultureInfo.InvariantCulture;
        public CultureInfo DateTimeCulture { get; set; } = CultureInfo.InvariantCulture;
    }
}