namespace Maestria.Extensions.FluentCast.Test.``To Int 16``
open FsUnit
open NUnit.Framework
open Maestria.Extensions.FluentCast
open Maestria.Extensions.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to Int16``() = StringFixedPointInput.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String to Int16 exception``() = (fun () -> StringBrokenInput.ToInt16() |> ignore) |> should throw typeof<System.FormatException>

    [<Test>]
    let ``Convert floating point string to Int32``() = StringFloatingPointInvariantInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int16``() = Int16Input.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int16``() = Int32Input.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int16``() = Int64Input.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int16``() = DecimalInput.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int16``() = FloatInput.ToInt16() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int16``() = DoubleInput.ToInt16() |> should equal FixedPointExpected

module ``Safe`` =
    [<Test>]
    let ``Convert String to Int16 Safe``() = StringFixedPointInput.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String broken to Int16 Safe Nullable``() = StringBrokenInput.ToInt16Safe() |> should be null

    [<Test>]
    let ``Convert String broken to Int16 Safe``() = StringBrokenInput.ToInt16Safe(Int16Input) |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String empty to Int16 Safe Nullable``() = StringEmptyInput.ToInt16Safe() |> should be null

    [<Test>]
    let ``Convert String empty to Int16 Safe``() = StringEmptyInput.ToInt16Safe(Int16Input) |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int16 Safe``() = Int16Input.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int16 Safe``() = Int32Input.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int16 Safe``() = Int64Input.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int16 Safe``() = DecimalInput.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int16 Safe``() = FloatInput.ToInt16Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int16 Safe``() = DoubleInput.ToInt16Safe() |> should equal FixedPointExpected
    
module ``Is Valid Int16`` =
    [<Test>]
    let ``Valid Int16``() = StringFloatingPointInvariantInput.IsValidInt16() |> should be True

    [<Test>]
    let ``Invalid Int16``() = StringBrokenInput.IsValidInt16() |> should be False    