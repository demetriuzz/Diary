using Diary.Api;
using Serilog;

public class Program
{
    static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddTimeService();

        Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        WebApplication app = builder.Build();

        app.Run(async context =>
        {
            Log.Information("Обработка запроса");
            var timeService = app.Services.GetService<TimeService>();
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync($"Текущее время: {timeService?.GetTime()}");
        });

        app.Run();
    }

}
