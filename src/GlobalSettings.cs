using System;
using Maestria.Extensions.FluentCast.Settings;

namespace Maestria.Extensions.FluentCast
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