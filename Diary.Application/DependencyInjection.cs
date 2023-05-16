using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Application.Services;

namespace Application;

public static class DependencyInjection
{

    /// <summary>
    /// Extensions: Add Diary Services
    /// </summary>
    /// <param name="services"></param>
    public static void AddDiaryApplication(this IServiceCollection services) {
        services.AddSingleton<IDiaryService, DiaryService>();
    }

}
