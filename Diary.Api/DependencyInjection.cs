namespace Diary.Api;

public static class DependencyInjection
{

    /// <summary>
    /// Extension: Add Swagger (OpenAPI)
    /// </summary>
    /// <param name="application"></param>
    /// <param name="environment"></param>
    public static void UseDiaryApiSwagger(this IApplicationBuilder application, IWebHostEnvironment environment) {
        if (environment.IsDevelopment()) {
            application.UseSwagger();
            application.UseSwaggerUI(options => {
                options.SwaggerEndpoint("v1/swagger.json", "API v1");
            });
        }
    }

}
