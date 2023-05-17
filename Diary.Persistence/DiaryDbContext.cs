using Diary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diary.Persistence;

public class DiaryDbContext : DbContext
{
    public DbSet<Note> Notes { get; set; } = null!;

    public DiaryDbContext(DbContextOptions options) : base(options)
    {
    }
}