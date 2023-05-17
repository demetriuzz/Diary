using Diary.Application.Models;

namespace Diary.Application.Interfaces;

public interface INoteEntityService
{

    /// <summary>
    /// Get Note by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public NoteEntity GetNoteById(int id);

    /// <summary>
    /// Get All Notes
    /// </summary>
    /// <returns></returns>
    public List<NoteEntity> GetNotes();

    /// <summary>
    /// Add Note
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public NoteEntity AddNote(NoteEntity entity);

    /// <summary>
    /// Update Note
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public NoteEntity UpdateNote(NoteEntity entity);

    /// <summary>
    /// Delete Note by id
    /// </summary>
    /// <param name="id"></param>
    public void DeleteNote(int id);

}
