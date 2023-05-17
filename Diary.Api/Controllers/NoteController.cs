using Diary.Application.Exception;
using Microsoft.AspNetCore.Mvc;
using Diary.Application.Interfaces;

namespace Diary.Api.Controllers;

[ApiController]
[Route("api/[controller]/")] // class name "NoteController" - mark "[controller]" = path "note"
public class NoteController : ControllerBase
{

    private readonly INoteEntityService _noteEntityService;

    public NoteController(INoteEntityService noteEntityService) {
        _noteEntityService = noteEntityService;
    }

    [HttpGet("get")]
    public IResult GetAll()
    {
        return Results.Json(_noteEntityService.GetNotes());
    }

    [HttpGet("get/{id:int}")]
    public IResult GetById(int id) {
        return Results.Json(_noteEntityService.GetNoteById(id));
    }

    [HttpDelete("delete/{id:int}")]
    public IResult DeleteById(int id)
    {
        try
        {
            _noteEntityService.DeleteNote(id);
            return Results.NoContent();
        }
        catch (DataNotFoundException e) 
        {
            return Results.NotFound($"{e.Message}");
        }
    }
}
