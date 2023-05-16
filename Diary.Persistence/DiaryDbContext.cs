using Diary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diary.Persistence;

public sealed class DiaryDbContext : DbContext
{
    public DbSet<Note> Notes => Set<Note>();

    public DiaryDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=diary.db");
    }
}
