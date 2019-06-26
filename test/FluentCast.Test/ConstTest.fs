module FluentCastTestConst
open System
open System.Globalization

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