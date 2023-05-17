using Microsoft.EntityFrameworkCore;

namespace Diary.Persistence.SQLite;

internal class SqliteDbContext : DiaryDbContext
{
    public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
    {
    }
}