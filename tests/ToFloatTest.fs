namespace Maestria.Extensions.FluentCast.Test.``To Float``
open FsUnit
open NUnit.Framework
open Maestria.Extensions.FluentCast
open Maestria.Extensions.FluentCast.Test.Const

module ``Unsafe`` =
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
    let ``Convert Int16 to Float``() = Int16Input.ToFloat() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Float``() = Int32Input.ToFloat() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Float``() = Int64Input.ToFloat() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Float``() = DecimalInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Float to Float``() = FloatInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Double to Float``() = DoubleInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

module ``Safe`` =
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
    let ``Convert Int16 to Float Safe``() = Int16Input.ToFloatSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Float Safe``() = Int32Input.ToFloatSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Float Safe``() = Int64Input.ToFloatSafe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Float Safe``() = DecimalInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Float to Float Safe``() = FloatInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

    [<Test>]
    let ``Convert Double to Float Safe``() = DoubleInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected
    
module ``Is Valid Float`` =
    [<Test>]
    let ``Valid Float``() = StringFloatingPointInvariantInput.IsValidFloat() |> should be True

    [<Test>]
    let ``Invalid Float``() = StringBrokenInput.IsValidFloat() |> should be False    