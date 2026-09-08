# Text & Identifier Conversion Extensions (`src/ToStringExtensions.cs`, `ToByteArrayExtensions.cs`, `ToGuidExtensions.cs`)

Fluent conversion involving `string`: safe `ToString()`, byte array encoding, and `Guid` parsing.

## Index

- [1. Safe string conversion (`ToStringSafe`)](#1-safe-string-conversion-tostringsafe)
- [2. Byte array conversion (`ToByteArray`)](#2-byte-array-conversion-tobytearray)
- [3. Guid conversion (`ToGuid`, `ToGuidSafe`, `IsValidGuid`)](#3-guid-conversion-toguid-toguidsafe-isvalidguid)

---

### 1. Safe string conversion (`ToStringSafe`)

Calls `ToString()` on any object, returning `null` instead of throwing when the value is `null` or `ToString()` itself throws.

#### Signatures
```csharp
string ToStringSafe(this object value);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

((object) null).ToStringSafe();  // null
42.ToStringSafe();                // "42"
```

---

### 2. Byte array conversion (`ToByteArray`)

Converts a `string` to `byte[]` using UTF-8 by default, or a specific `Encoding`.

#### Signatures
```csharp
byte[] ToByteArray(this string value);
byte[] ToByteArray(this string value, Encoding encoding);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;
using System.Text;

"hello".ToByteArray();               // UTF-8 bytes
"hello".ToByteArray(Encoding.ASCII); // ASCII bytes
```

---

### 3. Guid conversion (`ToGuid`, `ToGuidSafe`, `IsValidGuid`)

Parses a `string` into a `Guid`, with unsafe, safe, and validation variants.

#### Signatures
```csharp
Guid ToGuid(this string value);
Guid? ToGuidSafe(this string value);
bool IsValidGuid(this string value, IFormatProvider provider = null);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid();      // parsed Guid
"broken input".ToGuid();                              // throws FormatException

"broken input".ToGuidSafe();                          // null

"a7fb69ba-7922-4d88-9569-d8d0d6641b86".IsValidGuid();  // true
"broken input".IsValidGuid();                          // false
```
