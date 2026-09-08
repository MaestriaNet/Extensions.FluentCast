# Maestria.Extensions.FluentCast

[![NuGet Version](https://img.shields.io/nuget/v/Maestria.Extensions.FluentCast)](https://www.nuget.org/packages/Maestria.Extensions.FluentCast/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Maestria.Extensions.FluentCast)](https://www.nuget.org/packages/Maestria.Extensions.FluentCast/)
[![Apimundo](https://img.shields.io/badge/Maestria.Extensions.FluentCast%20API-Apimundo-728199.svg)](https://apimundo.com/organizations/nuget-org/nuget-feeds/public/packages/Maestria.Extensions.FluentCast/versions/latest?tab=types)

---

- [What is Maestria.Extensions.FluentCast?](#what-is-maestriaextensionsfluentcast)
- [What is Maestria Project?](#what-is-maestria-project)
- [Where can I get it?](#where-can-i-get-it)
- [How do I get started?](#how-do-i-get-started)
- [Settings](#settings)
- [Full usage documentations](#full-usage-documentations)

---

[![buy-me-a-coffee](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/btn_donate.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

---

## What is Maestria.Extensions.FluentCast?

This package provider a fluent syntax to simple data conversions.
Extension functions package for simple data convert.

## What is Maestria Project?

This library is part of Maestria Project.

Maestria is a project to provide maximum productivity and elegance to your code.

## Where can I get it?

Install the [Maestria.Extensions.FluentCast](https://www.nuget.org/packages/Maestria.Extensions.FluentCast/) using the command line:

```bash
dotnet add package Maestria.Extensions.FluentCast
```

## How do I get started?

First, import "Maestria.Extensions.FluentCast" reference:

```csharp
using Maestria.Extensions.FluentCast;
```

Then in your application code, use fluent syntax:

```csharp
// 1. Fixed point conversion
"150".ToInt32();      // string to int32 => 150
"150.345".ToInt32();  // string to int32, truncated => 150
150.345.ToInt32();    // double to int32, truncated => 150

// 2. Floating point conversion with culture
"150.45".ToFloat();                                        // uses default number culture
"150.45".ToDouble(CultureInfo.GetCultureInfo("en"));       // USA decimal separator "."
"150,45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR"));   // Brazil decimal separator ","

// 3. Date and time conversion with culture
"2019-06-29 13:31:59".ToDateTime();                                     // uses default datetime culture
"6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));      // USA format "M/d/yyyy h:mm tt"
"29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));  // Brazil format "dd/MM/yyyy HH:mm"

// 4. Guid conversion
"a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid(); // string to Guid

// 5. String and byte array conversion
((object) null).ToStringSafe();      // null-safe ToString() => null
"hello".ToByteArray();               // string to byte[] using default encoding
"hello".ToByteArray(Encoding.UTF8);  // string to byte[] using a specific encoding

// 6. Boolean conversion
"true".ToBoolean();     // string to bool => true
1.ToBoolean();          // int to bool => true

// 7. Enum conversion
"Monday".ToEnum<DayOfWeek>();  // string to enum => DayOfWeek.Monday
1.ToEnum<DayOfWeek>();         // int to enum => DayOfWeek.Monday

// 8. Object cast
object obj = "hello";
obj.CastAs<string>();  // safe cast, "value as T" => "hello"
obj.CastTo<string>();  // unsafe cast, "(T) value" => "hello"

// 9. Safe conversion — returns a fallback instead of throwing
"broken input".ToInt32Safe();                   // output is a nullable int => null
"broken input".ToInt32Safe(-1);                 // output is an int => -1
"broken input".ToDateTimeSafe();                // output is a nullable DateTime => null
"broken input".ToDateTimeSafe(DateTime.Today);  // output is a DateTime => today

// 10. Validation — check convertibility without throwing
"150".IsValidInt32();           // true
"broken input".IsValidInt32();  // false
"Monday".IsValidEnum<DayOfWeek>(); // true

// 11. Unsafe conversion — throws on invalid input
"broken input".ToInt32();     // throws FormatException
"broken input".ToDecimal();   // throws FormatException
"broken input".ToDateTime();  // throws FormatException
"broken input".ToGuid();      // throws FormatException
```

---

## Settings

It's possible set default culture format for library, when not configured, default culture is CultureInfo.InvariantCulture:

```csharp
MaestriaFluentCastSettings.Configure(config => config
    .NumberCulture(<culture-info>) // Default is CultureInfo.InvariantCulture
    .DateTimeCulture(<culture-info>)); // Default is CultureInfo.InvariantCulture
```

> See [docs/usage/settings.md](docs/usage/settings.md) for full documentation.

---

## Full usage documentations

There are many more extension methods available. See the full documentation:

| Topic                                              | Sample methods                                                    |
|-----------------------------------------------------|---------------------------------------------------------------------|
| [Numeric conversions](docs/usage/numeric.md)         | `ToInt16`, `ToInt32`, `ToInt64`, `ToFloat`, `ToDouble`, `ToDecimal`, `*Safe`, `IsValid*` |
| [Date & time conversions](docs/usage/datetime.md)    | `ToDateTime`, `ToTimeSpan`, `*Safe`, `IsValid*`                     |
| [Text & identifier conversions](docs/usage/text.md)  | `ToStringSafe`, `ToByteArray`, `ToGuid`, `ToGuidSafe`, `IsValidGuid` |
| [Boolean conversions](docs/usage/boolean.md)         | `ToBoolean`, `ToBooleanSafe`, `IsValidBoolean`                      |
| [Enum conversions](docs/usage/enum.md)               | `ToEnum<T>`, `ToEnumSafe<T>`, `IsValidEnum<T>`                      |
| [Object cast](docs/usage/object-cast.md)             | `CastAs<T>`, `CastTo<T>`                                            |
| [Settings](docs/usage/settings.md)                   | `MaestriaFluentCastSettings.Configure`                              |

---

[![buy-me-a-coffee](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/btn_donate.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
