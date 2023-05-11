namespace Diary.Api
{
    public class Diary
    {
        // todo id
        public DateOnly Day { get; set; } = DateOnly.Parse(DateTime.UtcNow.ToShortDateString());
        public TimeOnly? Time { get; set; } = TimeOnly.Parse(DateTime.UtcNow.ToShortTimeString());
        public string Note { get; set; } = "todo";

    }

}
