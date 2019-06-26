module FluentCastTest.``To Float``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToFloat
/// ===========================================
[<Test>]
let ``Convert String invariant to Float - Fixed Point``() = StringFixedPointInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Float - Floating Point``() = StringFloatingPointInvariantInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Fixed Point``() = StringFixedPointInput.ToFloat(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Floating Point``() = StringFloatingPointPtBtSourceInput.ToFloat(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String to Float exception``() = (fun () -> StringBrokenInput.ToFloat() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Float``() = ShortInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Float``() = IntInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Float``() = LongInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Float``() = DecimalInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Float``() = FloatInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Float``() = DoubleInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToFloatSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Float - Fixed Point Safe``() = StringFixedPointInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Float - Floating Point Safe``() = StringFloatingPointInvariantInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Fixed Point Safe``() = StringFixedPointInput.ToFloatSafe(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Floating Point Safe``() = StringFloatingPointPtBtSourceInput.ToFloatSafe(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String broken to Float Safe Nullable``() = StringBrokenInput.ToFloatSafe() |> should be null

[<Test>]
let ``Convert String broken to Float Safe``() = StringBrokenInput.ToFloatSafe(FloatInput) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Short to Float Safe``() = ShortInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Float Safe``() = IntInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Float Safe``() = LongInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Float Safe``() = DecimalInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Float Safe``() = FloatInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Float Safe``() = DoubleInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected