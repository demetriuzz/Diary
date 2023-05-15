using Microsoft.AspNetCore.Mvc;
using Application.Models;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]/")] // class name "DiaryController" - mark "[controller]" = path "diary"
public class DiaryController : ControllerBase
{

    [HttpGet("empty")]
    public IResult GetEmpty()
    {
        return Results.Json(new DiaryEntity());
    }

}
