# Date & Time Conversion Extensions (`src/ToDateTimeExtensions.cs`, `ToTimeSpan.cs`)

Fluent conversion from `object` to `DateTime` and `TimeSpan`.

Both accept an optional `IFormatProvider` (usually a `CultureInfo`). When omitted, the culture configured in [`MaestriaFluentCastSettings.DateTimeCulture`](settings.md) is used.

## Index

- [1. Unsafe conversion (`ToDateTime`, `ToTimeSpan`)](#1-unsafe-conversion-todatetime-totimespan)
- [2. Safe conversion (`ToDateTimeSafe`, `ToTimeSpanSafe`)](#2-safe-conversion-todatetimesafe-totimespansafe)
- [3. Validation (`IsValidDateTime`, `IsValidTimeSpan`)](#3-validation-isvaliddatetime-isvalidtimespan)

---

### 1. Unsafe conversion (`ToDateTime`, `ToTimeSpan`)

Converts an `object` to `DateTime` or `TimeSpan`. Throws an exception when the value is `null` or not convertible.

#### Signatures
```csharp
DateTime ToDateTime(this object value, IFormatProvider provider = null);
TimeSpan ToTimeSpan(this object value, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"2019-06-29 13:31:59".ToDateTime();                                     // uses default datetime culture
"6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));      // USA format "M/d/yyyy h:mm tt"
"29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));  // Brazil format "dd/MM/yyyy HH:mm"

"13:31:59".ToTimeSpan();  // TimeSpan of 13h31m59s

"broken input".ToDateTime();  // throws FormatException
```

---

### 2. Safe conversion (`ToDateTimeSafe`, `ToTimeSpanSafe`)

Returns `null` (or a supplied default) instead of throwing when the input is `null`, blank, or invalid.

#### Signatures
```csharp
DateTime? ToDateTimeSafe(this object value, IFormatProvider provider = null);
DateTime ToDateTimeSafe(this object value, DateTime @default, IFormatProvider provider = null);

TimeSpan? ToTimeSpanSafe(this object value, IFormatProvider provider = null);
TimeSpan ToTimeSpanSafe(this object value, TimeSpan @default, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"broken input".ToDateTimeSafe();                // null
"broken input".ToDateTimeSafe(DateTime.Today);  // today's date

"broken input".ToTimeSpanSafe();                // null
"broken input".ToTimeSpanSafe(TimeSpan.Zero);   // TimeSpan.Zero
```

---

### 3. Validation (`IsValidDateTime`, `IsValidTimeSpan`)

Checks whether a value can be converted without actually needing the result.

#### Signatures
```csharp
bool IsValidDateTime(this object value, IFormatProvider provider = null);
bool IsValidTimeSpan(this object value, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"2019-06-29 13:31:59".IsValidDateTime();  // true
"broken input".IsValidDateTime();         // false

"13:31:59".IsValidTimeSpan();  // true
"broken input".IsValidTimeSpan();  // false
```
