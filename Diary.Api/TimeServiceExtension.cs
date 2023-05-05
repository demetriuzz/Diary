namespace Diary.Api
{
    public static class TimeServiceExtension
    {
        public static void AddTimeService(this IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }
    }
}
