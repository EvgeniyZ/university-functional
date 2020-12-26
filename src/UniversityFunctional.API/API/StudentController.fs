namespace UniversityFunctional.API

open System
open Microsoft.AspNetCore.Mvc
open Domain

[<Route("api/[controller]")>]
[<ApiController>]
type StudentController() =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        let values = [| "value1"; "value2" |]
        ActionResult<string []>(values)
        
    [<HttpPost>]
    member this.Post(NewStudent newStudent) =
        let createStudentCommand = {data=newStudent, Timestamp = DateTime.UtcNow, UserId = Guid.New().ToString()}
            
