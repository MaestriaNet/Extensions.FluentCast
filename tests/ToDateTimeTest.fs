namespace Maestria.FluentCast.Test.``To DateTime``
open FsUnit
open NUnit.Framework
open Maestria.FluentCast
open Maestria.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String invariant to Date without time``() = StringDateInvariantInput.ToDateTime() |> should equal DateExpected

    [<Test>]
    let ``Convert String invariant to Date with time``() = StringDateTimeInvariantInput.ToDateTime() |> should equal DateTimeExpected

    [<Test>]
    let ``Convert String pt-BR to Date with time``() = StringDateTimePtBrInput.ToDateTime(CulturePtBr) |> should equal DateTimeExpected

    [<Test>]
    let ``Convert String pt-BR to Date without time``() = StringDatePtBrInput.ToDateTime(CulturePtBr) |> should equal DateExpected

    [<Test>]
    let ``Convert String to Date exception``() = (fun () -> StringBrokenInput.ToDateTime() |> ignore) |> should throw typeof<System.FormatException>

module ``Safe`` =
    [<Test>]
    let ``Convert String invariant to Date without time Safe``() = StringDateInvariantInput.ToDateTimeSafe() |> should equal DateExpected

    [<Test>]
    let ``Convert String invariant to Date with time Safe``() = StringDateTimeInvariantInput.ToDateTimeSafe() |> should equal DateTimeExpected

    [<Test>]
    let ``Convert String pt-BR to Date with time Safe``() = StringDateTimePtBrInput.ToDateTimeSafe(CulturePtBr) |> should equal DateTimeExpected

    [<Test>]
    let ``Convert String pt-BR to Date without time Safe``() = StringDatePtBrInput.ToDateTimeSafe(CulturePtBr) |> should equal DateExpected

    [<Test>]
    let ``Convert String broken to Date Safe Nullable``() = StringBrokenInput.ToDateTimeSafe() |> should be Null

    [<Test>]
    let ``Convert String broken to Date Safe``() = StringBrokenInput.ToDateTimeSafe(DateTimeExpected) |> should equal DateTimeExpected

module ``Is Valid DateTime`` =
    [<Test>]
    let ``Valid Date``() = StringDateInvariantInput.IsValidDateTime() |> should be True

    [<Test>]
    let ``Invalid Date``() = StringBrokenInput.IsValidDateTime() |> should be False