module FluentCastTest.``To Decimal``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToDecimal
/// ===========================================
[<Test>]
let ``Convert String invariant to Decimal - Fixed Point``() = StringFixedPointInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Decimal - Floating Point``() = StringFloatingPointInvariantInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal - Fixed Point``() = StringFixedPointInput.ToDecimal(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDecimal(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String to Decimal exception``() = (fun () -> StringBrokenInput.ToDecimal() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Decimal``() = ShortInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Decimal``() = IntInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Decimal``() = LongInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Decimal``() = DecimalInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Decimal``() = FloatInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Decimal``() = DoubleInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToDecimalSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Decimal Safe - Fixed Point``() = StringFixedPointInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Decimal Safe - Floating Point``() = StringFloatingPointInvariantInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal Safe - Fixed Point``() = StringFixedPointInput.ToDecimalSafe(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal Safe - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDecimalSafe(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String broken to Decimal Safe Nullable``() = StringBrokenInput.ToDecimalSafe() |> should be null

[<Test>]
let ``Convert String broken to Decimal Safe``() = StringBrokenInput.ToDecimalSafe(DecimalInput) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Short to Decimal Safe``() = ShortInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Decimal Safe``() = IntInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Decimal Safe``() = LongInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Decimal Safe``() = DecimalInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Decimal Safe``() = FloatInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Decimal Safe``() = DoubleInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected
