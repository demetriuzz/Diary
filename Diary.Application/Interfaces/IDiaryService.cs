using Diary.Application.Models;

namespace Diary.Application.Interfaces;

public interface IDiaryService
{

    /// <summary>
    /// Get Note by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public NoteEntity GetNoteById(int id);

    /// <summary>
    /// Get Notes by Date range
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public List<NoteEntity> GetNotesByRange(DateOnly from, DateOnly to);

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
