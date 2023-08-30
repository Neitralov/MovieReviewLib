namespace Database;

public class MovieRepository : IMovieRepository
{
    private readonly DatabaseContext _database;
    
    public MovieRepository(IDbContextFactory<DatabaseContext> factory)
    {
        _database = factory.CreateDbContext();
    }

    public void Dispose()
    {
        _database.DisposeAsync();
    }

    public void AddMovie(Movie movie)
    {
        _database.AddAsync(movie);
    }

    public void RemoveMovie(Movie movie)
    {
        if (_database.Movies.Contains(movie))
            _database.Remove(movie);
    }

    public void UpdateMovie(Movie movie)
    {
        _database.Movies.Update(movie);
    }

    public void SaveChanges()
    {
        _database.SavingChanges += (dbContext, args) =>
        {
            var trackedEntities = ((DbContext)dbContext!).ChangeTracker.Entries();
            foreach (var entity in trackedEntities)
            {
                if (entity.State is EntityState.Modified or EntityState.Added && entity.Entity is Movie movie)
                    ((DbContext)dbContext).Entry(movie).Property("UpdatedOn").CurrentValue = DateTime.Now;
            }
        };
        
        _database.SaveChanges();
    }

    public List<MovieDto> GetWatchedMovies(SortType sortType, MovieType movieType, string tag)
    {
        return _database.Movies
            .AsNoTracking()
            .Include(movie => movie.Tags)
            .Where(movie => movie.IsWatched == true)
            .OrderMovieBy(sortType)
            .FilterMovieByType(movieType)
            .FilterMovieByTag(tag)
            .MapMoviesToDto()
            .ToList();
    }

    public List<MovieDto> GetShelvedMovies(SortType sortType, MovieType movieType, string tag)
    {
        return _database.Movies
            .AsNoTracking()
            .Include(movie => movie.Tags)
            .Where(movie => movie.IsWatched == false)
            .OrderMovieBy(sortType)
            .FilterMovieByType(movieType)
            .FilterMovieByTag(tag)
            .MapMoviesToDto()
            .ToList();
    }

    public List<MovieDto> GetMoviesByName(SortType sortType, MovieType movieType, string tag, string name)
    {
        return _database.Movies
            .AsNoTracking()
            .Include(movie => movie.Tags)
            .OrderMovieBy(sortType)
            .FilterMovieByType(movieType)
            .FilterMovieByTag(tag)
            .MapMoviesToDto()
            .AsEnumerable()
            .Where(movie => movie.Title.ToLower().Contains(name.ToLower()))
            .ToList();
    }

    public Movie? GetMovieById(int id)
    {
        return _database.Movies
            .Include(movie => movie.Tags)
            .SingleOrDefault(movie => movie.MovieId == id);
    }

    public bool HasAnyWatchedMovie()
    {
        return _database.Movies.Any(movie => movie.IsWatched == true);
    }

    public bool HasAnyShelvedMovie()
    {
        return _database.Movies.Any(movie => movie.IsWatched == false);
    }

    public bool HasMovie(Movie movie)
    {
        return _database.Movies.Contains(movie);
    }

    public List<string> GetAllTags()
    {
        return _database.Movies
            .SelectMany(movie => movie.Tags)
            .Select(tag => tag.Value)
            .Distinct()
            .AsEnumerable()
            .Order()
            .ToList();
    }
}