# Boolean Conversion Extensions (`src/ToBooleanExtensions.cs`)

Fluent conversion from `object` to `bool`.

## Index

- [1. Unsafe conversion (`ToBoolean`)](#1-unsafe-conversion-toboolean)
- [2. Safe conversion (`ToBooleanSafe`)](#2-safe-conversion-tobooleansafe)
- [3. Validation (`IsValidBoolean`)](#3-validation-isvalidboolean)

---

### 1. Unsafe conversion (`ToBoolean`)

Converts an `object` to `bool`. Throws an exception when the value is `null` or not convertible.

#### Signatures
```csharp
bool ToBoolean(this object value);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"true".ToBoolean();   // true
1.ToBoolean();         // true
"broken input".ToBoolean(); // throws FormatException
```

---

### 2. Safe conversion (`ToBooleanSafe`)

Returns `null` (or a supplied default) instead of throwing when the input is `null`, blank, or invalid.

#### Signatures
```csharp
bool? ToBooleanSafe(this object value);
bool ToBooleanSafe(this object value, bool @default);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"broken input".ToBooleanSafe();        // null
"broken input".ToBooleanSafe(false);   // false
```

---

### 3. Validation (`IsValidBoolean`)

Checks whether a value can be converted without actually needing the result.

#### Signatures
```csharp
bool IsValidBoolean(this object value);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

"true".IsValidBoolean();          // true
"broken input".IsValidBoolean();  // false
```
