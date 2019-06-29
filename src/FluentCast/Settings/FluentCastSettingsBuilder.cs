using System.Globalization;

namespace FluentCast.Settings
{
    public class FluentCastSettingsBuilder
    {
        private readonly FluentCastSettings _instance;

        public FluentCastSettingsBuilder(FluentCastSettings instance)
        {
            _instance = instance;
        }

        public FluentCastSettingsBuilder NumberCulture(CultureInfo value)
        {
            _instance.NumberCulture = value;
            return this;
        }

        public FluentCastSettingsBuilder DateTimeCulture(CultureInfo value)
        {
            _instance.DateTimeCulture = value;
            return this;
        }
    }
}