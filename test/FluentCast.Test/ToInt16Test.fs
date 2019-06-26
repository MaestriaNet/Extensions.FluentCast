module FluentCastTest.``To Int 16``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToInt16
/// ===========================================
[<Test>]
let ``Convert String to Short``() = StringFixedPointInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert String to Short exception``() = (fun () -> StringBrokenInput.ToInt16() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Short``() = ShortInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Short``() = IntInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Short``() = LongInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Short``() = DecimalInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Short``() = FloatInput.ToInt16() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Short``() = DoubleInput.ToInt16() |> should equal FixedPointExpected

/// ===========================================
/// ToInt16Safe
/// ===========================================
[<Test>]
let ``Convert String to Short Safe``() = StringFixedPointInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String broken to Short Safe Nullable``() = StringBrokenInput.ToInt16Safe() |> should be null

[<Test>]
let ``Convert String broken to Short Safe``() = StringBrokenInput.ToInt16Safe(ShortInput) |> should equal FixedPointExpected

[<Test>]
let ``Convert String empty to Short Safe Nullable``() = StringEmptyInput.ToInt16Safe() |> should be null

[<Test>]
let ``Convert String empty to Short Safe``() = StringEmptyInput.ToInt16Safe(ShortInput) |> should equal FixedPointExpected

[<Test>]
let ``Convert Short to Short Safe``() = ShortInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Short Safe``() = IntInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Short Safe``() = LongInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Short Safe``() = DecimalInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Short Safe``() = FloatInput.ToInt16Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Short Safe``() = DoubleInput.ToInt16Safe() |> should equal FixedPointExpected