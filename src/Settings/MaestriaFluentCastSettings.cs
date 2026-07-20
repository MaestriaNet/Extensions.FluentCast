using System;
using System.Globalization;

namespace Maestria.Extensions.FluentCast;

// Model
public partial class MaestriaFluentCastSettings
{
    public CultureInfo NumberCulture { get; set; } = CultureInfo.InvariantCulture;
    public CultureInfo DateTimeCulture { get; set; } = CultureInfo.InvariantCulture;
}

// Factory
public partial class MaestriaFluentCastSettings
{
    static MaestriaFluentCastSettings()
    {
        Builder = new MaestriaFluentCastSettingsBuilder(Properties);
    }

    private static readonly MaestriaFluentCastSettingsBuilder Builder;

    public static MaestriaFluentCastSettings Properties { get; } = new();


    public static void Configure(Action<MaestriaFluentCastSettingsBuilder> cfg) => cfg(Builder);
}