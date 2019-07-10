namespace FluentCast.Test.Internal.``Convert Extensions``
open System
open FsUnit
open NUnit.Framework
open FluentCast.Internal
open FluentCast.Test.Const

module ``Convert Safe`` =
    [<Test>]
    let ``Null value convert not throw exception``() = ConvertExtensions.ConvertToSafe(null, fun value -> Convert.ToInt32(value)) |> should be Null

    [<Test>]
    let ``Empty string convert should be null``() = ConvertExtensions.ConvertToSafe(String.Empty, fun value -> Convert.ToInt32(value)) |> should be Null

    [<Test>]
    let ``Simple data convert``() = ConvertExtensions.ConvertToSafe(StringFixedPointInput, fun value -> Convert.ToInt32(value)) |> should equal FixedPointExpected