using Diary.Application.Interfaces;
using Diary.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.Persistence;

public static class DependencyInjection
{
    public static void AddDiaryPersistence(this IServiceCollection services)
    {
        // add repository
        services.AddScoped<INoteRepository, NoteRepository>();
    }
}