namespace Database;

public class DatabaseContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();

    public DatabaseContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Database/Database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .Property(p => p.Type)
            .HasConversion<string>();
        
        modelBuilder.Entity<Movie>()
            .Property<DateTime>("UpdatedOn");
    }
}