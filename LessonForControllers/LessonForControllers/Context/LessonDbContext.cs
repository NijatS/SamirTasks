using LessonForControllers.Models;
using Microsoft.EntityFrameworkCore;

namespace LessonForControllers.Context;

public class LessonDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }

    public LessonDbContext(DbContextOptions<LessonDbContext> options) : base(options)
    {
        
    }
}