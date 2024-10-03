using Microsoft.EntityFrameworkCore;
using SMS.Models;

namespace SMS.Context;

public class SMSDbContext : DbContext
{
    public DbSet<Group> Groups { get; set; }


    public SMSDbContext(DbContextOptions<SMSDbContext> options):base(options)
    {
        
    }
}