namespace Diary.Api
{
 
    /// <summary>
    /// What need do
    /// </summary>
    public class Diary
    {
        // todo id

        /// <summary>
        /// When need do: day in year
        /// </summary>
        public DateOnly Day { get; set; } = DateOnly.Parse(DateTime.UtcNow.ToShortDateString());

        /// <summary>
        /// When need do: time
        /// </summary>
        public TimeOnly? Time { get; set; } = TimeOnly.Parse(DateTime.UtcNow.ToShortTimeString());

        /// <summary>
        /// What do it
        /// </summary>
        public string Note { get; set; } = "todo";

    }

}
