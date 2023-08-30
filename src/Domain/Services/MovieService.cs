namespace Domain.Services;

public class MovieService
{
    private readonly IMovieRepository _repository;
    
    public MovieService(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public void Dispose()
    {
        _repository.Dispose();
    }
    
    public void RemoveMovie(Movie movie)
    {
        _repository.RemoveMovie(movie);
        _repository.SaveChanges();
    }
    
    public void SaveMovie(Movie movie)
    {
        if (_repository.GetMovieById(movie.MovieId) is null)
            _repository.AddMovie(movie);
        else
            _repository.UpdateMovie(movie);
        
        _repository.SaveChanges();
    }
    
    public List<MovieDto> GetWatchedMovies(SortType sortType, MovieType movieType, string tag)
    {
        return _repository.GetWatchedMovies(sortType, movieType, tag);
    }
    
    public List<MovieDto> GetShelvedMovies(SortType sortType, MovieType movieType, string tag)
    {
        return _repository.GetShelvedMovies(sortType, movieType, tag);
    }
    
    public List<MovieDto> GetMoviesByName(SortType sortType, MovieType movieType, string tag, string name)
    {
        return _repository.GetMoviesByName(sortType, movieType, tag, name);
    }
    
    public Movie? GetMovieById(int id)
    {
        return _repository.GetMovieById(id);
    }
    
    public bool HasAnyWatchedMovie()
    {
        return _repository.HasAnyWatchedMovie();
    }
    
    public bool HasAnyShelvedMovie()
    {
        return _repository.HasAnyShelvedMovie();
    }
    
    public bool HasMovie(Movie movie)
    {
        return _repository.HasMovie(movie);
    }
    
    public List<string> GetAllTags()
    {
        return _repository.GetAllTags();
    }
}