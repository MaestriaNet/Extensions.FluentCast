# Maestria.Extensions.FluentCast

[![NuGet Version](https://img.shields.io/nuget/v/Maestria.Extensions.FluentCast)](https://www.nuget.org/packages/Maestria.Extensions.FluentCast/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Maestria.Extensions.FluentCast)](https://www.nuget.org/packages/Maestria.Extensions.FluentCast/)
[![Apimundo](https://img.shields.io/badge/Maestria.Extensions.FluentCast%20API-Apimundo-728199.svg)](https://apimundo.com/organizations/nuget-org/nuget-feeds/public/packages/Maestria.Extensions.FluentCast/versions/latest?tab=types)

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
// all to fixed point
"150".ToInt16();        // string to int16 conversion
"150".ToInt32();        // string to int32 conversion
"150".ToInt64();        // string to int64 conversion
"150.345".ToInt32();    // string to int32 conversion, output is a int32 = 150
150.345.ToInt32();      // double to int32 covnersion, output is a int32 = 150

// all to floating point
"150.45".ToFloat();                                         // use default number culture configured at the application startup
"150.45".ToDouble(CultureInfo.GetCultureInfo("en"));        // use USA decimal separator ","
"150,45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR"));    // use Brazil decimal separator "."

// all to date time
"2019-06-29 13:31:59".ToDateTime();                                     // use default datetime culture configured at the application startup
"6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));      // use USA datetime format "M/d/yyyy h:mm tt"
"29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));  // use Brazil datetime format "dd/MM/yyyy HH:mm"

// string to guid
"a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid(); // output is a Guid

// all to string
((object) null).ToStringSafe(); // output is a null string

// byte array
<string>.ToByteArray()
<string>.ToByteArray(<encoding>)

// safe conversion support
"broken input".ToInt32Safe();                   // output is nullable int
"broken input".ToInt32Safe(-1);                 // output is -1
"broken input".ToDateTimeSafe();                // output is nullable DateTime
"broken input".ToDateTimeSafe(DateTime.Today);  // output is today DateTime

// exception throws - Broken inputs values throw exeption on unsafe mode
"broken input".ToInt32();
"broken input".ToDecimal();
"broken input".ToDateTime();
"broken input".ToGuid();
```

---

It's possible set default culture format for library, when not configured, default culture is CultureInfo.InvariantCulture:

```csharp
MaestriaFluentCastSettings.Configure(cfg => cfg
    .NumberCulture(CultureInfo.InvariantCulture)
    .DateTimeCulture(CultureInfo.GetCultureInfo("en")));
```

---

[![buy-me-a-coffee](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://raw.githubusercontent.com/MaestriaNet/Extensions.FluentCast/master/resources/btn_donate.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
