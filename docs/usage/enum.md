# Enum Conversion Extensions (`src/ToEnumExtensions.cs`)

Fluent conversion from `object` to an `enum` type, accepting the enum's own type, `char`, integral numbers, or a matching `string` name.

## Index

- [1. Unsafe conversion (`ToEnum<T>`)](#1-unsafe-conversion-toenumt)
- [2. Safe conversion (`ToEnumSafe<T>`)](#2-safe-conversion-toenumsafet)
- [3. Validation (`IsValidEnum<T>`)](#3-validation-isvalidenumt)

---

### 1. Unsafe conversion (`ToEnum<T>`)

Converts an `object` to the enum type `T`. Throws an exception when the value is `null` or not a valid member.

#### Signatures
```csharp
T ToEnum<T>(this object value) where T : struct;
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

enum Status { Active, Inactive }

"Active".ToEnum<Status>();  // Status.Active
0.ToEnum<Status>();         // Status.Active
Status.Active.ToEnum<Status>(); // Status.Active

((object) null).ToEnum<Status>();  // throws ArgumentNullException
"Unknown".ToEnum<Status>();        // throws ArgumentException
```

---

### 2. Safe conversion (`ToEnumSafe<T>`)

Returns `null` (or a supplied default) instead of throwing when the input is `null` or not a valid member.

#### Signatures
```csharp
T? ToEnumSafe<T>(this object value) where T : struct;
T ToEnumSafe<T>(this object value, T @default) where T : struct;
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"Unknown".ToEnumSafe<Status>();               // null
"Unknown".ToEnumSafe(Status.Inactive);        // Status.Inactive
```

---

### 3. Validation (`IsValidEnum<T>`)

Checks whether a value can be converted without actually needing the result.

#### Signatures
```csharp
bool IsValidEnum<T>(this object value) where T : struct;
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"Active".IsValidEnum<Status>();   // true
"Unknown".IsValidEnum<Status>();  // false
```
