using Diary.Application.Interfaces;
using Diary.Application.Models;

namespace Diary.Application.Services;

public class NoteEntityService : INoteEntityService
{
    INoteRepository _noteRepository;

    public NoteEntityService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    public NoteEntity AddNote(NoteEntity entity)
    {
        // todo
        return new NoteEntity { ToDo = "Add" };
    }

    public void DeleteNote(int id)
    {
        _noteRepository.Delete(id);
    }

    public List<NoteEntity> GetNotes()
    {
        // fixme Note ->  NoteEntity
        return new List<NoteEntity>();
    }

    public NoteEntity GetNoteById(int id)
    {
        // todo
        return new NoteEntity { ToDo = "Get" };
    }

    public NoteEntity UpdateNote(NoteEntity entity)
    {
        // todo
        return new NoteEntity { ToDo = "Update" };
    }
}