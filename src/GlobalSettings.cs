using System;
using Maestria.FluentCast.Settings;

namespace Maestria.FluentCast
{
    public static class GlobalSettings
    {
        static GlobalSettings()
        {
            Builder = new FluentCastSettingsBuilder(Properties);
        }

        private static readonly FluentCastSettingsBuilder Builder;

        public static FluentCastSettings Properties { get; } = new FluentCastSettings();


        public static void Configure(Action<FluentCastSettingsBuilder> cfg) => cfg(Builder);
    }
}