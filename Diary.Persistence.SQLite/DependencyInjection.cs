using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Diary.Persistence.SQLite;

public static class DependencyInjection
{
    public static void AddDiaryPersistenceSqlite(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DiaryDbContext, SqliteDbContext>(options =>
        {
            options.UseSqlite(connectionString);
            options.LogTo(Console.WriteLine); // logging
        });
    }
}