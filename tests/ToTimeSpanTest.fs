namespace Maestria.Extensions.FluentCast.Test.``To TimeSpan``
open FsUnit
open NUnit.Framework
open Maestria.Extensions.FluentCast
open Maestria.Extensions.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to TimeSpan``() = StringTimeSpanInvariantInput.ToTimeSpan() |> should equal TimeSpanExpected

    [<Test>]
    let ``Convert String to TimeSpan greater 24 hours``() = StringTimeSpanGreater24HoursInvariantInput.ToTimeSpan() |> should equal TimeSpanGreater24HoursExpected

module ``Safe`` =
    [<Test>]
    let ``Convert String to TimeSpan Safe``() = StringTimeSpanInvariantInput.ToTimeSpanSafe() |> should equal TimeSpanExpected

    [<Test>]
    let ``Convert String to TimeSpan greater 24 hours``() = StringTimeSpanGreater24HoursInvariantInput.ToTimeSpanSafe() |> should equal TimeSpanGreater24HoursExpected

    [<Test>]
    let ``Convert String broken to TimeSpan Safe Nullable``() = StringBrokenInput.ToTimeSpanSafe() |> should be Null