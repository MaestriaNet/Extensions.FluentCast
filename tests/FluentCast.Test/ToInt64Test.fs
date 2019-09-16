namespace Maestria.FluentCast.Test.``To Int 64``
open FsUnit
open NUnit.Framework
open Maestria.FluentCast
open Maestria.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to Int64``() = StringFixedPointInput.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String to Int64 exception``() = (fun () -> StringBrokenInput.ToInt64() |> ignore) |> should throw typeof<System.FormatException>

    [<Test>]
    let ``Convert floating point string to Int32``() = StringFloatingPointInvariantInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int64``() = Int16Input.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int64``() = Int32Input.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int64``() = Int64Input.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int64``() = DecimalInput.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int64``() = FloatInput.ToInt64() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int64``() = DoubleInput.ToInt64() |> should equal FixedPointExpected

module ``Safe`` =
    [<Test>]
    let ``Convert String to Int64 Safe``() = StringFixedPointInput.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String broken to Int64 Safe Nullable``() = StringBrokenInput.ToInt64Safe() |> should be null

    [<Test>]
    let ``Convert String broken to Int64 Safe``() = StringBrokenInput.ToInt64Safe(Int64Input) |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int64 Safe``() = Int16Input.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int64 Safe``() = Int32Input.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int64 Safe``() = Int64Input.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int64 Safe``() = DecimalInput.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int64 Safe``() = FloatInput.ToInt64Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int64 Safe``() = DoubleInput.ToInt64Safe() |> should equal FixedPointExpected