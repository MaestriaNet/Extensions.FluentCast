module Biofa.Framework.Utils.Test.ConverUtilsTest
open System
open System.Globalization
open FsUnit
open NUnit.Framework
open FluentCast

/// ===========================================
/// Diferentes tipos de dados para Convert
/// ===========================================
let StringFixedPointInput: string = "16"
let StringFloatingPointInvariantInput: string = "16.1"
let StringFloatingPointPtBtSourceInput: string = "16,1"
let ShortInput: int16 = 16s
let IntInput: int = 16
let LongInput: int64 = 16L
let DecimalInput: decimal = 16.1m
let FloatInput: float32 = 16.1F
let DoubleInput: double = 16.1

let StringEmptyInput = String.Empty
let StringDateInvariantInput = "2019-05-30"
let StringDateTimeInvariantInput = "2019-05-30 23:41:15"
let StringDatePtBrInput = "30/05/2019"
let StringDateTimePtBrInput = "30/05/2019 23:41:15"
let StringGuidInput = "ccc220ea-dd08-455f-b053-1002cc2bd117"

let StringBrokenInput = "!@#$%abc"

/// ===========================================
/// Expected values
/// ===========================================
let FixedPointExpected: int64 = 16L
let FloatingPointExpected: decimal = 16.1m
let DateExpected: DateTime = DateTime.ParseExact("2019-05-30", "yyyy-MM-dd", CultureInfo.InvariantCulture)
let DateTimeExpected: DateTime = DateTime.ParseExact("2019-05-30 23:41:15", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
let GuidExpected: Guid = Guid.Parse(StringGuidInput)

let CulturePtBr = CultureInfo.CreateSpecificCulture("pt-BR")

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

/// ===========================================
/// ToInt
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
/// ToIntSafe
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

/// ===========================================
/// ToDecimal
/// ===========================================
[<Test>]
let ``Convert String invariant to Decimal - Fixed Point``() = StringFixedPointInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Decimal - Floating Point``() = StringFloatingPointInvariantInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal - Fixed Point``() = StringFixedPointInput.ToDecimal(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDecimal(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String to Decimal exception``() = (fun () -> StringBrokenInput.ToDecimal() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Decimal``() = ShortInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Decimal``() = IntInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Decimal``() = LongInput.ToDecimal() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Decimal``() = DecimalInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Decimal``() = FloatInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Decimal``() = DoubleInput.ToDecimal() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToDecimalSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Decimal Safe - Fixed Point``() = StringFixedPointInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Decimal Safe - Floating Point``() = StringFloatingPointInvariantInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal Safe - Fixed Point``() = StringFixedPointInput.ToDecimalSafe(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Decimal Safe - Floating Point``() = StringFloatingPointPtBtSourceInput.ToDecimalSafe(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String broken to Decimal Safe Nullable``() = StringBrokenInput.ToDecimalSafe() |> should be null

[<Test>]
let ``Convert String broken to Decimal Safe``() = StringBrokenInput.ToDecimalSafe(DecimalInput) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Short to Decimal Safe``() = ShortInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Decimal Safe``() = IntInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Decimal Safe``() = LongInput.ToDecimalSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Decimal Safe``() = DecimalInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Decimal Safe``() = FloatInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Decimal Safe``() = DoubleInput.ToDecimalSafe() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToFloat
/// ===========================================
[<Test>]
let ``Convert String invariant to Float - Fixed Point``() = StringFixedPointInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Float - Floating Point``() = StringFloatingPointInvariantInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Fixed Point``() = StringFixedPointInput.ToFloat(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Floating Point``() = StringFloatingPointPtBtSourceInput.ToFloat(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String to Float exception``() = (fun () -> StringBrokenInput.ToFloat() |> ignore) |> should throw typeof<System.FormatException>

[<Test>]
let ``Convert Short to Float``() = ShortInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Float``() = IntInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Float``() = LongInput.ToFloat() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Float``() = DecimalInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Float``() = FloatInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Float``() = DoubleInput.ToFloat() |> should (equalWithin 0.0001) FloatingPointExpected

/// ===========================================
/// ToFloatSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Float - Fixed Point Safe``() = StringFixedPointInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert String invariant to Float - Floating Point Safe``() = StringFloatingPointInvariantInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Fixed Point Safe``() = StringFixedPointInput.ToFloatSafe(CulturePtBr) |> should equal FixedPointExpected

[<Test>]
let ``Convert String pt-BR to Float - Floating Point Safe``() = StringFloatingPointPtBtSourceInput.ToFloatSafe(CulturePtBr) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert String broken to Float Safe Nullable``() = StringBrokenInput.ToFloatSafe() |> should be null

[<Test>]
let ``Convert String broken to Float Safe``() = StringBrokenInput.ToFloatSafe(FloatInput) |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Short to Float Safe``() = ShortInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Int to Float Safe``() = IntInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Long to Float Safe``() = LongInput.ToFloatSafe() |> should equal FixedPointExpected

[<Test>]
let ``Convert Decimal to Float Safe``() = DecimalInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Float to Float Safe``() = FloatInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

[<Test>]
let ``Convert Double to Float Safe``() = DoubleInput.ToFloatSafe() |> should (equalWithin 0.0001) FloatingPointExpected

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

/// ===========================================
/// ToDateTime
/// ===========================================
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

/// ===========================================
/// ToDateTimeSafe
/// ===========================================
[<Test>]
let ``Convert String invariant to Date without time Safe``() = StringDateInvariantInput.ToDateTimeSafe() |> should equal DateExpected

[<Test>]
let ``Convert String invariant to Date with time Safe``() = StringDateTimeInvariantInput.ToDateTimeSafe() |> should equal DateTimeExpected

[<Test>]
let ``Convert String pt-BR to Date with time Safe``() = StringDateTimePtBrInput.ToDateTimeSafe(CulturePtBr) |> should equal DateTimeExpected

[<Test>]
let ``Convert String pt-BR to Date without time Safe``() = StringDatePtBrInput.ToDateTimeSafe(CulturePtBr) |> should equal DateExpected

[<Test>]
let ``Convert String broken to Date Safe Nullable``() = StringBrokenInput.ToDateTimeSafe() |> should be null

[<Test>]
let ``Convert String broken to Date Safe``() = StringBrokenInput.ToDateTimeSafe(DateTimeExpected) |> should equal DateTimeExpected

/// ===========================================
/// ToGuid
/// ===========================================
[<Test>]
let ``Convert String to Guid``() = StringGuidInput.ToGuid() |> should equal GuidExpected

[<Test>]
let ``Convert String Broken to Guid exception``() = (fun () -> StringBrokenInput.ToGuid() |> ignore) |> should throw typeof<FormatException>

/// ===========================================
/// ToGuidSafe
/// ===========================================
[<Test>]
let ``Convert String to Guid Safe``() = StringGuidInput.ToGuidSafe() |> should equal GuidExpected

[<Test>]
let ``Convert String Broken to Guid Safe``() = StringBrokenInput.ToGuidSafe() |> should be null

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