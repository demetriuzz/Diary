using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Diary.Api
{
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
            // todo database
            services.AddControllers();
            services.AddHealthChecks()
                .AddCheck("api", () => HealthCheckResult.Healthy());
        }

        /// <summary>
        /// Use on Runtime (Application)
        /// </summary>
        public void Configure(IApplicationBuilder application)
        {
            // application.UseHeaderPropagation(); // need service .. ?

            application.UseHttpsRedirection();

            application.UseRouting();

            application.UseEndpoints(endpoints => { // + service need
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/healthcheck", new HealthCheckOptions
                {
                    ResponseWriter = async (context, report) =>
                    {
                        await UIResponseWriter.WriteHealthCheckUIResponse(context, report);
                    }
                });
            });
        }
    }
}
