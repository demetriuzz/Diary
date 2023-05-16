using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Application;

namespace Api;

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
        // todo: database
        services.AddDiaryApplication();
        services.AddControllers();

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
    public void Configure(IApplicationBuilder application)
    {
        // application.UseHeaderPropagation(); // fix: need service

        application.UseHttpsRedirection(); // https -> http, when error

        application.UseRouting();

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
