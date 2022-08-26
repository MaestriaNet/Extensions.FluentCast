namespace Maestria.Extensions.FluentCast.Test.``To Int 32``
open FsUnit
open NUnit.Framework
open Maestria.Extensions.FluentCast
open Maestria.Extensions.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to Int32``() = StringFixedPointInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String to Int exception``() = (fun () -> StringBrokenInput.ToInt32() |> ignore) |> should throw typeof<System.FormatException>

    [<Test>]
    let ``Convert floating point string to Int32``() = StringFloatingPointInvariantInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int32``() = Int16Input.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int32``() = Int32Input.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int32``() = Int64Input.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int32``() = DecimalInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int32``() = FloatInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int32``() = DoubleInput.ToInt32() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String to Int32 Number bug``() = StringInt32Bug.ToInt32() |> should equal 1327857152

module ``Safe`` =
    [<Test>]
    let ``Convert String to Int32 Safe``() = StringFixedPointInput.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert String broken to Int32 Safe Nullable``() = StringBrokenInput.ToInt32Safe() |> should be null

    [<Test>]
    let ``Convert String broken to Int32 Safe``() = StringBrokenInput.ToInt32Safe(Int32Input) |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int16 to Int32 Safe``() = Int16Input.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int32 to Int32 Safe``() = Int32Input.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Int64 to Int32 Safe``() = Int64Input.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Decimal to Int32 Safe``() = DecimalInput.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Float to Int32 Safe``() = FloatInput.ToInt32Safe() |> should equal FixedPointExpected

    [<Test>]
    let ``Convert Double to Int32 Safe``() = DoubleInput.ToInt32Safe() |> should equal FixedPointExpected
    
module ``Is Valid Int32`` =
    [<Test>]
    let ``Valid Int32``() = StringFloatingPointInvariantInput.IsValidInt32() |> should be True

    [<Test>]
    let ``Invalid Int32``() = StringBrokenInput.IsValidInt32() |> should be False    