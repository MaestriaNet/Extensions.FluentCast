module FluentCastTest.``To Int 32``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToInt32
/// ===========================================
[<Test>]
let ``Convert String to Int32``() = StringFixedPointInput.ToInt32() |> should equal FixedPointExpected

[<Test>]
let ``Convert String to Int exception``() = (fun () -> StringBrokenInput.ToInt32() |> ignore) |> should throw typeof<System.FormatException>

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

/// ===========================================
/// ToInt32Safe
/// ===========================================
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