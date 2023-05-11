using Microsoft.AspNetCore.Mvc;

namespace Diary.Api.Controllers
{

    [ApiController]
    [Route("api/diary/")] // [controller] + DiaryController = diary
    public class DiaryController : ControllerBase
    {

        [HttpGet("empty")]
        public IResult GetEmpty()
        {
            return Results.Json(new Diary());
        }

    }

}
