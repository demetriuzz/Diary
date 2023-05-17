using Microsoft.Extensions.DependencyInjection;
using Diary.Application.Interfaces;
using Diary.Application.Services;

namespace Diary.Application;

public static class DependencyInjection
{

    /// <summary>
    /// Extensions: Add Diary Services
    /// </summary>
    /// <param name="services"></param>
    public static void AddDiaryApplication(this IServiceCollection services) {
        services.AddScoped<INoteEntityService, NoteEntityService>();
    }

}
