using System.Globalization;

namespace Maestria.Extensions.FluentCast;

public class MaestriaFluentCastSettingsBuilder(MaestriaFluentCastSettings instance)
{
    public MaestriaFluentCastSettingsBuilder NumberCulture(CultureInfo value)
    {
        instance.NumberCulture = value;
        return this;
    }

    public MaestriaFluentCastSettingsBuilder DateTimeCulture(CultureInfo value)
    {
        instance.DateTimeCulture = value;
        return this;
    }
}