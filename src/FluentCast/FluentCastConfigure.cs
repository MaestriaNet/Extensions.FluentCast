using FluentCast.Settings;

namespace FluentCast
{
    public static class FluentCast
    {
        public static FluentCastSettings Settings { get; } = new FluentCastSettings();

        public static FluentCastSettings Configure() => Settings;
    }
}