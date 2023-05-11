using Serilog;

namespace Diary.Api;

public class Program
{
    static void Main(string[] args)
    {
        Host.CreateDefaultBuilder(args)
            .UseSerilog((context, services, configuration) => configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services))
            .ConfigureWebHostDefaults(configure => {
                configure.UseStartup<Startup>();
            })
            .Build()
            .Run();
    }

}
