using Application.Models;

namespace Application.Interfaces;

public interface IDiaryService
{

    /// <summary>
    /// Get Diary by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public DiaryEntity GetDiaryEntity(int id);

    /// <summary>
    /// Get Diary by Date range
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <returns></returns>
    public List<DiaryEntity> GetDiaryEntitiesByRange(DateOnly from, DateOnly to);

    /// <summary>
    /// Add Diary
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public DiaryEntity AddDiary(DiaryEntity entity);

    /// <summary>
    /// Update Diary
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public DiaryEntity UpdateDiary(DiaryEntity entity);

    /// <summary>
    /// Delete Diary by id
    /// </summary>
    /// <param name="id"></param>
    public void DeleteDiary(int id);

}
