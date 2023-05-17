using Diary.Domain.Entities;

namespace Diary.Application.Interfaces;

/// <summary>
/// Repository for entity 'Note'
/// </summary>
public interface INoteRepository
{
    /// <summary>
    /// Get All Entity
    /// </summary>
    /// <returns></returns>
    public List<Note> GetAll();

    /// <summary>
    /// Get Entity by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Note GetById(int id);

    /// <summary>
    /// Add Entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public Note Add(Note entity);

    /// <summary>
    /// Update Entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public Note Update(Note entity);

    /// <summary>
    /// Delete Entity by id
    /// </summary>
    /// <param name="id"></param>
    public void Delete(int id);
}