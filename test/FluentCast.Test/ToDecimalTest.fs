namespace FluentCast.Test.``To Decimal``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCast.Test.Const

module ``Unsafe`` =
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
    let ``Convert Int16 to Decimal``() = Int16Input.ToDecimal() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Decimal``() = Int32Input.ToDecimal() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Decimal``() = Int64Input.ToDecimal() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Decimal``() = DecimalInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Float to Decimal``() = FloatInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Double to Decimal``() = DoubleInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

module ``Safe`` =
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
    let ``Convert Int16 to Decimal Safe``() = Int16Input.ToDecimalSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Decimal Safe``() = Int32Input.ToDecimalSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Decimal Safe``() = Int64Input.ToDecimalSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Decimal Safe``() = DecimalInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Float to Decimal Safe``() = FloatInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Double to Decimal Safe``() = DoubleInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected