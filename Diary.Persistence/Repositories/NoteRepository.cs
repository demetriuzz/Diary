using Diary.Application.Exception;
using Diary.Application.Interfaces;
using Diary.Domain.Entities;

namespace Diary.Persistence.Repositories;

public class NoteRepository : INoteRepository
{
    private readonly DiaryDbContext _dbContext;

    public NoteRepository(DiaryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Note> GetAll()
    {
        return _dbContext.Notes.ToList();
    }

    public Note GetById(int id)
    {
        Note? note = _dbContext.Notes.Find(id);

        if (note is null) throw new DataNotFoundException(id);

        return note;
    }

    public Note Add(Note entity)
    {
        _dbContext.Notes.Add(entity);
        // fixme
        _dbContext.SaveChanges();
        return entity;
    }

    public Note Update(Note entity)
    {
        _dbContext.Notes.Update(entity);
        // fixme
        _dbContext.SaveChanges();
        return entity;
    }

    public void Delete(int id)
    {
        Note? note = _dbContext.Notes.Find(id);

        if (note is null) throw new DataNotFoundException(id);

        _dbContext.Notes.Remove(note);
        _dbContext.SaveChanges();
    }
}