module Tests

open System
open Xunit
open Domain
open Domain.StudentAge
open FsUnit.Xunit

[<Theory>]
[<InlineData(-100)>]
[<InlineData(0)>]
[<InlineData(14)>]
[<InlineData(121)>]
let ``Student age with negative or less 15 and above 120 resulting with Error`` (age) =
    let studentAgeResult = create age
    match studentAgeResult with
    | Error msg -> Assert.NotEmpty(msg)
    | _ -> failwith "Expecting Error, found Ok"

[<Theory>]
[<InlineData(15)>]
[<InlineData(18)>]
[<InlineData(55)>]
[<InlineData(100)>]
[<InlineData(120)>]
let ``Student age within 15, 120 should be Ok`` (age) =
    let studentAgeResult = create age
    match studentAgeResult with
    | Ok age -> Assert.Equal(age, age)
    | _ -> failwith "Expecting Ok, found Error"
