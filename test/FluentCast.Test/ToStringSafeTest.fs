module FluentCastTest.``To String Safe``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToStringSafe
/// ===========================================
[<Test>]
let ``Convert String to String Safe``() = StringBrokenInput.ToStringSafe() |> should equal StringBrokenInput

[<Test>]
let ``Convert Int to String Safe``() = IntInput.ToStringSafe() |> should equal (FixedPointExpected.ToString())

[<Test>]
let ``Convert Decimal to String Safe``() = DecimalInput.ToStringSafe() |> should equal (FloatingPointExpected.ToString())

[<Test>]
let ``Convert null to String Safe``() = null.ToStringSafe() |> should be Null