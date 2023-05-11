namespace Diary.Api.ProbeClass
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();

    }

}
