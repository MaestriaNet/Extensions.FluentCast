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
"150".ToInt16(); // string to int16 conversion
"150".ToInt32(); // string to int32 conversion
"150".ToInt64(); // string to int64 conversion
"150.345".ToInt32(); // string to int32 conversion, out is a int32 = 150
150.345.ToInt32(); // double to int32 covnersion, out is a int32 = 150

// all to floating point
float floatInvariantValue = "150.45".ToFloat(); // use default culture configured at application startup
double doubleEnValue = "150,45".ToDouble(CultureInfo.GetCultureInfo("en")); // use USA decimal separator ","
decimal decimalPtValue = "150.45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR")); // use Brazilian decimal separator "."

// all to date time
DateTime dateInvariantValue = "2019-06-29 13:31:59".ToDateTime();
DateTime dateEnValue = "6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));
DateTime datePtValue = "29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));

// string to guid
Guid guidValue = "a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid();

// all to string
string stringValue = ((object) null).ToStringSafe(); // out is a null string

// safe conversion support
"broken input".ToInt32Safe(); // out is nullable int
"broken input".ToInt32Safe(-1); // out is -1
"broken input".ToDateTimeSafe(); // out is nullable DateTime
"broken input".ToDateTimeSafe(DateTime.Today); // out is today DateTime

// exception throws
"broken input".ToInt32();
"broken input".ToDecimal();
"broken input".ToDateTime();
"broken input".ToGuid();
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