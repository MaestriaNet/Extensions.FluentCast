namespace Maestria.FluentCast.Test.``To Byte Array``
open FsUnit
open NUnit.Framework
open Maestria.FluentCast

module ``Unsafe`` =
    [<Test>]
    let ``Convert String to Byte Array``() = "test".ToByteArray() |> should equal [| 116; 101; 115; 116 |]
