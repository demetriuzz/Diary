using Application.Interfaces;
using Application.Models;

namespace Application.Services;

public class DiaryService : IDiaryService
{
    public DiaryEntity AddDiary(DiaryEntity entity)
    {
        // todo
        return new DiaryEntity{ Note = "Add" };
    }

    public void DeleteDiary(int id)
    {
        // todo
    }

    public List<DiaryEntity> GetDiaryEntitiesByRange(DateOnly from, DateOnly to)
    {
        // todo
        return new List<DiaryEntity>();
    }

    public DiaryEntity GetDiaryEntity(int id)
    {
        // todo
        return new DiaryEntity{ Note = "Get" };
    }

    public DiaryEntity UpdateDiary(DiaryEntity entity)
    {
        // todo
        return new DiaryEntity{ Note = "Update" };
    }

}
