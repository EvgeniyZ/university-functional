namespace UniversityFunctional.API

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
