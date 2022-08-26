module Maestria.Extensions.FluentCast.Test.Const
open System
open System.Globalization

/// ===========================================
/// Input values in many data types
/// ===========================================
let StringFixedPointInput: string = "16"
let StringFloatingPointInvariantInput: string = "16.1"
let StringFloatingPointPtBtSourceInput: string = "16,1"
let Int16Input: int16 = 16s
let Int32Input: int = 16
let Int64Input: int64 = 16L
let DecimalInput: decimal = 16.1m
let FloatInput: float32 = 16.1F
let DoubleInput: double = 16.1

let StringInt32Bug = "1327857152"

let StringEmptyInput = String.Empty
let StringDateInvariantInput = "2019-05-30"
let StringDateTimeInvariantInput = "2019-05-30 23:41:15"
let StringDatePtBrInput = "30/05/2019"
let StringDateTimePtBrInput = "30/05/2019 23:41:15"
let StringGuidInput = "ccc220ea-dd08-455f-b053-1002cc2bd117"
let StringTimeSpanInvariantInput = "23:54:35"
let StringTimeSpanGreater24HoursInvariantInput = "1.23:54:35"

let StringBrokenInput = "!@#$%abc"

/// ===========================================
/// Expected values
/// ===========================================
let FixedPointExpected: int64 = 16L
let FloatingPointExpected: decimal = 16.1m
let DateExpected: DateTime = DateTime.ParseExact("2019-05-30", "yyyy-MM-dd", CultureInfo.InvariantCulture)
let DateTimeExpected: DateTime = DateTime.ParseExact("2019-05-30 23:41:15", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
let GuidExpected: Guid = Guid.Parse(StringGuidInput)
let TimeSpanExpected = new TimeSpan(23, 54, 35)
let TimeSpanGreater24HoursExpected = new TimeSpan(1, 23, 54, 35)

/// ===========================================
/// Constants
/// ===========================================
let CulturePtBr = CultureInfo.CreateSpecificCulture("pt-BR")