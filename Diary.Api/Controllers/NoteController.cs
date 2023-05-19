using System.Text.Json;
using Diary.Application.Exception;
using Microsoft.AspNetCore.Mvc;
using Diary.Application.Interfaces;
using Diary.Application.Models;

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
        try
        {
            return Results.Json(_noteEntityService.GetNoteById(id));
        }
        catch (DataNotFoundException e)
        {
            return Results.NotFound($"{e.Message}");
        }
    }

    [HttpPost("add")]
    public IResult Add(NoteEntity entity)
    {
        return Results.Json(_noteEntityService.AddNote(entity));
    }

    [HttpPut("update")]
    public IResult Update(NoteEntity entity)
    {
        return Results.Json(_noteEntityService.UpdateNote(entity));
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
