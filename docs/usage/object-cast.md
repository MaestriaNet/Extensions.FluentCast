# Object Cast Extensions (`src/CastExtensions.cs`)

Fluent shorthand for the standard C# `as` and direct cast operators.

## Index

- [1. Safe cast (`CastAs<T>`)](#1-safe-cast-castast)
- [2. Direct cast (`CastTo<T>`)](#2-direct-cast-castot)

---

### 1. Safe cast (`CastAs<T>`)

Equivalent to `value as T`. Returns `null` when the cast is not possible, instead of throwing.

#### Signatures
```csharp
T CastAs<T>(this object value) where T : class;
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

object value = "hello";
string text = value.CastAs<string>();   // "hello"
object number = 42;
string invalid = number.CastAs<string>(); // null
```

---

### 2. Direct cast (`CastTo<T>`)

Equivalent to `(T) value`. Throws an `InvalidCastException` when the cast is not possible.

#### Signatures
```csharp
T CastTo<T>(this object value);
```

#### Examples
```csharp
using Maestria.Extensions.FluentCast;

object value = 42;
int number = value.CastTo<int>();   // 42

object text = "hello";
int invalid = text.CastTo<int>();   // throws InvalidCastException
```
