namespace Diary.Domain.Entities;

public class Note
{
    public int Id { get; set; }

    public DateOnly Day { get; set; }

    public TimeOnly? Time { get; set; }

    public string? ToDo { get; set; }

}
