module FluentCastTest.``To Int 64``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToInt64
/// ===========================================
[<Test>]
let ``Convert String to Long``() = StringFixedPointInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert String to Long exception``() = (fun () -> StringBrokenInput.ToInt64() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Long``() = ShortInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Long``() = IntInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Long``() = LongInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Long``() = DecimalInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Long``() = FloatInput.ToInt64() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Long``() = DoubleInput.ToInt64() |> should equal FixedPointExpected

/// ===========================================
/// ToInt64Safe
/// ===========================================
[<Test>]
let ``Convert String to Long Safe``() = StringFixedPointInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String broken to Long Safe Nullable``() = StringBrokenInput.ToInt64Safe() |> should be null

[<Test>]
let ``Convert String broken to Long Safe``() = StringBrokenInput.ToInt64Safe(LongInput) |> should equal FixedPointExpected

[<Test>]
let ``Convert Short to Long Safe``() = ShortInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Long Safe``() = IntInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Long Safe``() = LongInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Long Safe``() = DecimalInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Float to Long Safe``() = FloatInput.ToInt64Safe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Double to Long Safe``() = DoubleInput.ToInt64Safe() |> should equal FixedPointExpected