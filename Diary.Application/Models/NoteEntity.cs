using System.ComponentModel.DataAnnotations;

namespace Diary.Application.Models;

/// <summary>
/// What need do
/// </summary>
public class NoteEntity
{

    public int Id { get; set; }

    /// <summary>
    /// When need do: day in year
    /// </summary>
    [Required]
    public DateOnly Day { get; set; }

    /// <summary>
    /// When need do: time
    /// </summary>
    public TimeOnly? Time { get; set; }

    /// <summary>
    /// What do it
    /// </summary>
    [Required]
    public string? ToDo { get; set; }

}
