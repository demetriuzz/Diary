using Microsoft.AspNetCore.Mvc;
using Application.Models;
using Application.Interfaces;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]/")] // class name "DiaryController" - mark "[controller]" = path "diary"
public class DiaryController : ControllerBase
{

    private readonly IDiaryService _diaryService;

    public DiaryController(IDiaryService diaryService) {
        _diaryService = diaryService;
    }

    [HttpGet("empty")]
    public IResult GetEmpty()
    {
        return Results.Json(new DiaryEntity());
    }

    [HttpGet("get/{id:int}")]
    public IResult GetDiaryById(int id) {
        return Results.Json(_diaryService.GetDiaryEntity(id));
    }

}
