using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public DbSet<User> Users { get; set; } // Example entity (replace with your actual entity)

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionString");
    }
}
