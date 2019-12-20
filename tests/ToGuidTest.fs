namespace Maestria.FluentCast.Test.``To GUID``
open System
open FsUnit
open NUnit.Framework
open Maestria.FluentCast
open Maestria.FluentCast.Test.Const

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to Guid``() = StringGuidInput.ToGuid() |> should equal GuidExpected

    [<Test>]
    let ``Convert String Broken to Guid exception``() = (fun () -> StringBrokenInput.ToGuid() |> ignore) |> should throw typeof<FormatException>

module ``Safe`` =
    [<Test>]
    let ``Convert String to Guid Safe``() = StringGuidInput.ToGuidSafe() |> should equal GuidExpected

    [<Test>]
    let ``Convert String Broken to Guid Safe``() = StringBrokenInput.ToGuidSafe() |> should be null

module ``Is Valid Guid`` =
    [<Test>]
    let ``Valid Guid``() = StringGuidInput.IsValidGuid() |> should be True

    [<Test>]
    let ``Invalid Guid``() = StringBrokenInput.IsValidGuid() |> should be False