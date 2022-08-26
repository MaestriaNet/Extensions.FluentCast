namespace Maestria.Extensions.FluentCast.Test.``Cast Extensions``
open System.Text
open FsUnit
open NUnit.Framework
open Maestria.Extensions.FluentCast
open Maestria.Extensions.FluentCast.Test.Const

module ``Cast As`` =
    [<Test>]
    let ``Null because inheritance is invalid``() = CastExtensions.CastAs<Encoding>(StringBrokenInput) |> should be Null

    [<Test>]
    let ``Success``() = CastExtensions.CastAs<string>(StringBrokenInput) |> should equal StringBrokenInput


module ``Cast To`` =
    [<Test>]
    let ``Exception because inheritance is invalid``() = (fun () -> CastExtensions.CastTo<Encoding>(StringBrokenInput) |> ignore) |> should throw typeof<System.InvalidCastException>

    [<Test>]
    let ``Success``() = CastExtensions.CastTo<string>(StringBrokenInput) |> should equal StringBrokenInput