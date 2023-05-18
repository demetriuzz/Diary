using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Diary.Persistence.SQLite;

public static class DependencyInjection
{
    public static void AddDiaryPersistenceSqlite(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DiaryDbContext, SqliteDbContext>(options =>
        {
            options.UseSqlite(connectionString);
            options.LogTo(Console.WriteLine, LogLevel.Information); // logging
        });
    }
}