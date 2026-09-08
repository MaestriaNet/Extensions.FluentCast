# Settings (`src/Settings`)

Global configuration for culture-dependent conversions.

## Index

- [1. Configuration (`MaestriaFluentCastSettings.Configure`)](#1-configuration-maestriafluentcastsettingsconfigure)

---

### 1. Configuration (`MaestriaFluentCastSettings.Configure`)

Sets the default `CultureInfo` used by number and date/time conversions when no `IFormatProvider` is passed explicitly. Both default to `CultureInfo.InvariantCulture`.

- `NumberCulture`: used by [`ToInt16`/`ToInt32`/`ToInt64`/`ToFloat`/`ToDouble`/`ToDecimal`](numeric.md).
- `DateTimeCulture`: used by [`ToDateTime`/`ToTimeSpan`](datetime.md).

#### Signatures
```csharp
static void MaestriaFluentCastSettings.Configure(Action<MaestriaFluentCastSettingsBuilder> cfg);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

MaestriaFluentCastSettings.Configure(config => config
    .NumberCulture(CultureInfo.GetCultureInfo("pt-BR"))
    .DateTimeCulture(CultureInfo.GetCultureInfo("pt-BR")));

// From now on, calls without an explicit provider use pt-BR
"150,45".ToDecimal();  // 150.45
```
