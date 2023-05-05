namespace Diary.Api
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();

    }

}
