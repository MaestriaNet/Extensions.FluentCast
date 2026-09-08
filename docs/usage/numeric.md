# Numeric Conversion Extensions (`src/ToInt16Extensions.cs`, `ToInt32Extensions.cs`, `ToInt64Extensions.cs`, `ToFloatExtensions.cs`, `ToDoubleExtensions.cs`, `ToDecimalExtensions.cs`)

Fluent conversion from `object` to the numeric types `short`, `int`, `long`, `float`, `double` and `decimal`.

All numeric conversions accept an optional `IFormatProvider` (usually a `CultureInfo`). When omitted, the culture configured in [`MaestriaFluentCastSettings.NumberCulture`](settings.md) is used.

## Index

- [1. Unsafe conversion (`ToInt16`, `ToInt32`, `ToInt64`, `ToFloat`, `ToDouble`, `ToDecimal`)](#1-unsafe-conversion-toint16-toint32-toint64-tofloat-todouble-todecimal)
- [2. Safe conversion (`*Safe`)](#2-safe-conversion-safe)
- [3. Validation (`IsValid*`)](#3-validation-isvalid)
- [4. Fixed-point rounding from floating point input](#4-fixed-point-rounding-from-floating-point-input)

---

### 1. Unsafe conversion (`ToInt16`, `ToInt32`, `ToInt64`, `ToFloat`, `ToDouble`, `ToDecimal`)

Converts an `object` to the target numeric type. Throws an exception when the value is `null`, empty, or not convertible.

#### Signatures
```csharp
short ToInt16(this object value, IFormatProvider provider = null);
int ToInt32(this object value, IFormatProvider provider = null);
long ToInt64(this object value, IFormatProvider provider = null);
float ToFloat(this object value, IFormatProvider provider = null);
double ToDouble(this object value, IFormatProvider provider = null);
decimal ToDecimal(this object value, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"150".ToInt32();      // 150
150.345.ToInt32();    // 150 (truncated)

"150.45".ToFloat();                                       // uses default number culture
"150.45".ToDouble(CultureInfo.GetCultureInfo("en"));       // USA decimal separator "."
"150,45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR"));   // Brazil decimal separator ","

"broken input".ToInt32();  // throws FormatException
((string) null).ToInt16(); // throws ArgumentNullException
```

---

### 2. Safe conversion (`*Safe`)

Returns `null` (or a supplied default) instead of throwing when the input is `null`, blank, or invalid.

#### Signatures
```csharp
short? ToInt16Safe(this object value, IFormatProvider provider = null);
short ToInt16Safe(this object value, short @default, IFormatProvider provider = null);
// Same pattern for ToInt32Safe, ToInt64Safe, ToFloatSafe, ToDoubleSafe, ToDecimalSafe
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"broken input".ToInt32Safe();     // null
"broken input".ToInt32Safe(-1);   // -1
"".ToDecimalSafe();               // null
"150.45".ToDoubleSafe(0d);        // 150.45
```

---

### 3. Validation (`IsValid*`)

Checks whether a value can be converted without actually needing the result.

#### Signatures
```csharp
bool IsValidInt16(this object value, IFormatProvider provider = null);
bool IsValidInt32(this object value, IFormatProvider provider = null);
bool IsValidInt64(this object value, IFormatProvider provider = null);
bool IsValidFloat(this object value, IFormatProvider provider = null);
bool IsValidDouble(this object value, IFormatProvider provider = null);
bool IsValidDecimal(this object value, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"150".IsValidInt32();           // true
"150.99".IsValidInt32();        // true (floating point auto converts to fixed point)
"broken input".IsValidInt32();  // false
```

---

### 4. Fixed-point rounding from floating point input

`ToInt16`, `ToInt32` and `ToInt64` accept floating point input (`string`, `float`, `double`, `decimal`) and truncate it to the fixed-point type instead of throwing.

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"150.345".ToInt32();  // 150 (parsed as float, then truncated)
150.345.ToInt32();    // 150
150.345m.ToInt32();   // 150
```
