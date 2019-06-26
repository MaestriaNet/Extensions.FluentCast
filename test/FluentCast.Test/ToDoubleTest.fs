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
let ``Convert Int16 to Double``() = Int16Input.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int32 to Double``() = Int32Input.ToDouble() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int64 to Double``() = Int64Input.ToDouble() |> should equal FixedPointExpected

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
let ``Convert Int16 to Double Safe``() = Int16Input.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int32 to Double Safe``() = Int32Input.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int64 to Double Safe``() = Int64Input.ToDoubleSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Double Safe``() = DecimalInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Double Safe``() = FloatInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Double Safe``() = DoubleInput.ToDoubleSafe() |> should (equalWithin 0.0001) FloatingPointExpected