using FluentCast.Settings;

namespace FluentCast
{
    public static class GlobalSettings
    {
        private static FluentCastSettingsBuilder _builder;

        public static FluentCastSettings Properties { get; } = new FluentCastSettings();

        public static FluentCastSettingsBuilder Configure() =>
            _builder ?? (_builder = new FluentCastSettingsBuilder(Properties));
    }
}