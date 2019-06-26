module FluentCastTest.``To Double``
open FsUnit
open NUnit.Framework
open FluentCast
open FluentCastTestConst

/// ===========================================
/// ToDouble
/// ===========================================
[<Test>]
let ``Convert String invariant to Double - Fixed Point``() = StringFixedPointInput.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Double invariant - Floating Point``() = StringFloatingPointInvariantInput.ToDouble() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Double - Fixed Point``() = StringFixedPointInput.ToDouble(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Double invariant - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDouble(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String to Double exception``() = (fun () -> StringBrokenInput.ToDouble() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Double``() = ShortInput.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Double``() = IntInput.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Double``() = LongInput.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Double``() = DecimalInput.ToDouble() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Double``() = FloatInput.ToDouble() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Double``() = DoubleInput.ToDouble() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToDoubleSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Double Safe - Fixed Point``() = StringFixedPointInput.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Double Safe - Floating Point``() = StringFloatingPointInvariantInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Double Safe - Fixed Point``() = StringFixedPointInput.ToDoubleSafe(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Double Safe - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDoubleSafe(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String broken to Double Safe Nullable``() = StringBrokenInput.ToDoubleSafe() |> should be null

[<Test>]
let ``Convert String broken to Double Safe``() = StringBrokenInput.ToDoubleSafe(DoubleInput) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Short to Double Safe``() = ShortInput.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Double Safe``() = IntInput.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Double Safe``() = LongInput.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Double Safe``() = DecimalInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Double Safe``() = FloatInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Double Safe``() = DoubleInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected