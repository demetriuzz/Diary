using Microsoft.AspNetCore.Mvc;

namespace Diary.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]/")] // mark "[controller]" + class name "DiaryController" = diary
    public class DiaryController : ControllerBase
    {

        [HttpGet("empty")]
        public IResult GetEmpty()
        {
            return Results.Json(new Diary());
        }

    }

}
