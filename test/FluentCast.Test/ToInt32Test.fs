module FluentCastTest.``To Int 32``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToInt32
/// ===========================================
[<Test>]
let ``Convert String to Int``() = StringFixedPointInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert String to Int exception``() = (fun () -> StringBrokenInput.ToInt32() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Int``() = ShortInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Int``() = IntInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Int``() = LongInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Int``() = DecimalInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Int``() = FloatInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Int``() = DoubleInput.ToInt32() |> should equal FixedPointExpected

/// ===========================================
/// ToInt32Safe
/// ===========================================
[<Test>]
let ``Convert String to Int Safe``() = StringFixedPointInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String broken to Int Safe Nullable``() = StringBrokenInput.ToInt32Safe() |> should be null

[<Test>]
let ``Convert String broken to Int Safe``() = StringBrokenInput.ToInt32Safe(IntInput) |> should equal FixedPointExpected

[<Test>]
let ``Convert Short to Int Safe``() = ShortInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Int Safe``() = IntInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Int Safe``() = LongInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Int Safe``() = DecimalInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Int Safe``() = FloatInput.ToInt32Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Int Safe``() = DoubleInput.ToInt32Safe() |> should equal FixedPointExpected