namespace Diary.Api.ProbeClass
{
    public static class TimeServiceExtension
    {
        public static void AddTimeService(this IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }
    }
}
