namespace Maestria.FluentCast.Test.``To String``
open FsUnit
open NUnit.Framework
open Maestria.FluentCast
open Maestria.FluentCast.Test.Const

module ``Safe`` =
    type ExceptionToStringType =
        {TestId: int}
        override m.ToString() = (0/0).ToString()

    [<Test>]
    let ``Convert String to String Safe``() = StringBrokenInput.ToStringSafe() |> should equal StringBrokenInput

    [<Test>]
    let ``Convert Int32 to String Safe``() = Int32Input.ToStringSafe() |> should equal (FixedPointExpected.ToString())

    [<Test>]
    let ``Convert Decimal to String Safe``() = DecimalInput.ToStringSafe() |> should equal (FloatingPointExpected.ToString())

    [<Test>]
    let ``Convert null to String Safe``() = null.ToStringSafe() |> should be Null

    [<Test>]
    let ``Convert invalid object to String``() = ({TestId = 0}).ToStringSafe() |> should be Null