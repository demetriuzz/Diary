using Diary.Application.Interfaces;
using Diary.Application.Models;

namespace Diary.Application.Services;

public class DiaryService : IDiaryService
{
    public NoteEntity AddNote(NoteEntity entity)
    {
        // todo
        return new NoteEntity{ ToDo = "Add" };
    }

    public void DeleteNote(int id)
    {
        // todo
    }

    public List<NoteEntity> GetNotesByRange(DateOnly from, DateOnly to)
    {
        // todo
        return new List<NoteEntity>();
    }

    public NoteEntity GetNoteById(int id)
    {
        // todo
        return new NoteEntity{ ToDo = "Get" };
    }

    public NoteEntity UpdateNote(NoteEntity entity)
    {
        // todo
        return new NoteEntity{ ToDo = "Update" };
    }

}
