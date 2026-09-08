# CLAUDE.md

Guidance for Claude Code when working in this repository.

## Documentation standards

When updating the README or `docs/usage/*.md`, follow these rules:

### README structure

- Top-level index right under the badges: flat `- [Section](#anchor)` bullet list, before the donate/buy-me-a-coffee block.
- "How do I get started?" example block: numbered comments (`// 1. ...`, `// 2. ...`), one short category per number (e.g. "Fixed point conversion", "Boolean conversion"), each line ending with a `//` comment showing the actual output. Group by conceptual category, not one example per method.
- A "Full usage documentations" section near the end with a markdown table `| Topic | Sample methods |`, one row per `docs/usage/*.md` file — topic column links to the file, methods column lists the actual method names it covers.

### `docs/usage/<topic>.md` structure

- H1 title referencing the source file(s) in backticks, e.g. `# Numeric Conversion Extensions (\`src/ToInt16Extensions.cs\`, ...)`.
- One-paragraph intro.
- `## Index` with anchor links to each numbered section.
- `---`-separated numbered `### N. Title` sections, each with:
  - `#### Signatures` — csharp code block with just method signatures.
  - `#### Examples` — csharp code block with inline `//` result comments.
- Group files by **data context** (numeric, datetime, text, boolean, enum, object-cast, settings), not by source file. Source files sharing a conversion pattern (e.g. `ToInt16Extensions.cs`, `ToInt32Extensions.cs`, `ToInt64Extensions.cs`, `ToFloatExtensions.cs`, `ToDoubleExtensions.cs`, `ToDecimalExtensions.cs`) get merged into one doc (`numeric.md`) rather than one file per class.
- Only create `docs/usage/` files/sections that are actually justified by the complexity of the topic — don't split trivially small topics into their own file.

### Auditing `src/` before writing docs

Before updating documentation, read every public extension class in `src/`, not just what the README currently shows — READMEs can drift out of sync with the code. Check each `To<Type>Extensions.cs` file for the full conversion pattern (see below) and flag any missing variant as undocumented.

## Conversion method pattern

Every conversion family in `src/` (`ToInt16/32/64`, `ToFloat/Double/Decimal`, `ToDateTime`, `ToTimeSpan`, `ToBoolean`, `ToEnum<T>`, `ToGuid`) follows the same four-method shape:

1. `To<Type>(this object value, IFormatProvider provider = null)` — throws on null/invalid input.
2. `To<Type>Safe(this object value, IFormatProvider provider = null)` — returns nullable, `null` on failure instead of throwing.
3. `To<Type>Safe(this object value, <Type> @default, IFormatProvider provider = null)` — returns the default instead of `null`.
4. `IsValid<Type>(this object value, IFormatProvider provider = null)` — bool check, implemented as `value.To<Type>Safe(provider) != null`.

Numeric conversions to fixed-point types (`ToInt16/32/64`) additionally accept floating-point input (`string`, `float`, `double`, `decimal`) and truncate rather than throw.

Culture-dependent conversions (numeric, date/time) fall back to `MaestriaFluentCastSettings.Properties.NumberCulture` / `.DateTimeCulture` (both default `CultureInfo.InvariantCulture`) when `provider` is omitted, configurable via `MaestriaFluentCastSettings.Configure(...)`.

When adding a new conversion type, replicate this exact four-method shape and settings fallback rather than inventing a new API surface.
