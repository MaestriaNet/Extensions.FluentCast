# FluentCast
This package provider a fluent syntax to simple data conversions

### How do I get started?
First, import "FluentCast" reference:

```csharp
using FluentCast;
```

Then in your application code, use fluent syntax: 

```csharp
// all to fixed point
"150".ToInt16();        // string to int16 conversion
"150".ToInt32();        // string to int32 conversion
"150".ToInt64();        // string to int64 conversion
"150.345".ToInt32();    // string to int32 conversion, out is a int32 = 150
150.345.ToInt32();      // double to int32 covnersion, out is a int32 = 150

// all to floating point
"150.45".ToFloat();                                         // use default number culture configured at the application startup
"150,45".ToDouble(CultureInfo.GetCultureInfo("en"));        // use USA decimal separator ","
"150.45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR"));    // use Brazil decimal separator "."

// all to date time
"2019-06-29 13:31:59".ToDateTime();                                     // use default datetime culture configured at the application startup
"6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));      // use USA datetime format "M/d/yyyy h:mm tt"
"29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));  // use Brazil datetime format "dd/MM/yyyy HH:mm"

// string to guid
"a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid(); // out is a Guid 

// all to string
string stringValue = ((object) null).ToStringSafe(); // out is a null string

// safe conversion support
"broken input".ToInt32Safe();                   // out is nullable int
"broken input".ToInt32Safe(-1);                 // out is -1
"broken input".ToDateTimeSafe();                // out is nullable DateTime
"broken input".ToDateTimeSafe(DateTime.Today);  // out is today DateTime

// exception throws - Broken inputs values throw exeption on unsafe mode
"broken input".ToInt32();
"broken input".ToDecimal();
"broken input".ToDateTime();
"broken input".ToGuid();
```

It's possible set default culture format for library, when not configured, default culture is CultureInfo.InvariantCulture:
```csharp
FluentCast.GlobalSettings.Configure(cfg => cfg
    .NumberCulture(CultureInfo.InvariantCulture)
    .DateTimeCulture(CultureInfo.GetCultureInfo("en")));
```

Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [FluentCast](https://www.nuget.org/packages/FluentCast/) from the package manager console:

```
PM> Install-Package FluentCast
```

or install from the dotnet cli command line:
```
> dotnet add package FluentCast
``` 