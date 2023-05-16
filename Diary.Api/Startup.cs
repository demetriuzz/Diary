using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Diary.Application;
using Diary.Persistence;

namespace Diary.Api;

public class Startup
{
    private IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    /// <summary>
    /// Use on Runtime (Services)
    /// </summary>
    /// <param name="services"></param>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDiaryPersistence();
        services.AddDiaryApplication();
        services.AddControllers();
        services.AddSwaggerGen();

        // point to check: total status = sum all point status
        services.AddHealthChecks()
            .AddCheck("api", () => HealthCheckResult.Healthy())
            .AddCheck("db", () => HealthCheckResult.Degraded())
            .AddCheck("x", () => HealthCheckResult.Unhealthy());
    }

    /// <summary>
    /// Use on Runtime (Application)
    /// </summary>
    /// <param name="application"></param>
    /// <param name="environment"></param>
    public void Configure(IApplicationBuilder application, IWebHostEnvironment environment)
    {
        // application.UseHeaderPropagation(); // fix: need service

        application.UseHttpsRedirection(); // https -> http, when error

        application.UseRouting();
        application.UseDiaryApiSwagger(environment);

        application.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHealthChecks("/healthcheck", new HealthCheckOptions
            {
                ResponseWriter = async (context, report) => await UIResponseWriter.WriteHealthCheckUIResponse(context, report)
            });
        });
    }
}
