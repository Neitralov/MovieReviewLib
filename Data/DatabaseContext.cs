using Microsoft.EntityFrameworkCore;

namespace MovieReviewLib.Data;

public sealed class DatabaseContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();

    //При миграции закомментировать конструктор
    public DatabaseContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //При миграциях установить: optionsBuilder.UseSqlite("Data Source=tmp/Database/Database.db");
        optionsBuilder.UseSqlite("Data Source=Database/Database.db");
    }
}