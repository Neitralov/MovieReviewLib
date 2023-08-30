namespace Domain;

public interface IMovieRepository
{
    void Dispose();
    void AddMovie(Movie movie);
    void RemoveMovie(Movie movie);
    void UpdateMovie(Movie movie);
    void SaveChanges();
    List<MovieDto> GetWatchedMovies(SortType sortType, MovieType movieType, string tag);
    List<MovieDto> GetShelvedMovies(SortType sortType, MovieType movieType, string tag);
    List<MovieDto> GetMoviesByName(SortType sortType, MovieType movieType, string tag, string name);
    Movie? GetMovieById(int id);
    bool HasAnyWatchedMovie();
    bool HasAnyShelvedMovie();
    bool HasMovie(Movie movie);
    List<string> GetAllTags();
}