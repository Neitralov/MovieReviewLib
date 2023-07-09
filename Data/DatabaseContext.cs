using Microsoft.EntityFrameworkCore;

namespace MovieReviewLib.Data;

public sealed class DatabaseContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();
    
    public DatabaseContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Database/Database.db");
    }
}