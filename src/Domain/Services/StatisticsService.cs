namespace Domain.Services;

public class StatisticsService
{
    private readonly IStatisticsRepository _repository;

    public StatisticsService(IStatisticsRepository repository)
    {
        _repository = repository;
    }
    
    public int GetNumberOfWatchedMovies()        => _repository.GetNumberOfWatchedMovies();
    public int GetNumberOfWatchedFilms()         => _repository.GetNumberOfWatchedFilms();
    public int GetNumberOfWatchedSeries()        => _repository.GetNumberOfWatchedSeries();
    public int GetNumberOfWatchedShows()         => _repository.GetNumberOfWatchedShows();
    public int GetNumberOfWatchedCartoons()      => _repository.GetNumberOfWatchedCartoons();
    public int GetNumberOfWatchedCartoonSeries() => _repository.GetNumberOfWatchedCartoonSeries();
    public int GetNumberOfWatchedAnime()         => _repository.GetNumberOfWatchedAnime();
    
    public int GetNumberOfPostponedMovies()        => _repository.GetNumberOfPostponedMovies();
    public int GetNumberOfPostponedFilms()         => _repository.GetNumberOfPostponedFilms();
    public int GetNumberOfPostponedSeries()        => _repository.GetNumberOfPostponedSeries();
    public int GetNumberOfPostponedShows()         => _repository.GetNumberOfPostponedShows();
    public int GetNumberOfPostponedCartoons()      => _repository.GetNumberOfPostponedCartoons();
    public int GetNumberOfPostponedCartoonSeries() => _repository.GetNumberOfPostponedCartoonSeries();
    public int GetNumberOfPostponedAnime()         => _repository.GetNumberOfPostponedAnime();
    
    public double GetAverageMovieRating()         => _repository.GetAverageMovieRating();
    public double GetAverageFilmRating()          => _repository.GetAverageFilmRating();
    public double GetAverageSeriesRating()        => _repository.GetAverageSeriesRating();
    public double GetAverageShowRating()          => _repository.GetAverageShowRating();
    public double GetAverageCartoonRating()       => _repository.GetAverageCartoonRating();
    public double GetAverageCartoonSeriesRating() => _repository.GetAverageCartoonSeriesRating();
    public double GetAverageAnimeRating()         => _repository.GetAverageAnimeRating();
    
    public MovieTitleWithScoreDto[] GetTop10FilmsByRaiting()         => _repository.GetTop10FilmsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10SeriesByRaiting()        => _repository.GetTop10SeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10ShowsByRaiting()         => _repository.GetTop10ShowsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonsByRaiting()      => _repository.GetTop10CartoonsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonSeriesByRaiting() => _repository.GetTop10CartoonSeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10AnimeByRaiting()         => _repository.GetTop10AnimeByRaiting();
    
    public MovieTitleWithReleaseYearDto? GetNewestWatchedMovie()         => _repository.GetNewestWatchedMovie();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedFilm()          => _repository.GetNewestWatchedFilm();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedSeries()        => _repository.GetNewestWatchedSeries();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedShow()          => _repository.GetNewestWatchedShow();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedCartoon()       => _repository.GetNewestWatchedCartoon();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedCartoonSeries() => _repository.GetNewestWatchedCartoonSeries();
    public MovieTitleWithReleaseYearDto? GetNewestWatchedAnime()         => _repository.GetNewestWatchedAnime();
    
    public MovieTitleWithReleaseYearDto? GetOldestWatchedMovie()         => _repository.GetOldestWatchedMovie();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedFilm()          => _repository.GetOldestWatchedFilm();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedSeries()        => _repository.GetOldestWatchedSeries();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedShow()          => _repository.GetOldestWatchedShow();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedCartoon()       => _repository.GetOldestWatchedCartoon();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedCartoonSeries() => _repository.GetOldestWatchedCartoonSeries();
    public MovieTitleWithReleaseYearDto? GetOldestWatchedAnime()         => _repository.GetOldestWatchedAnime();
    
    public int GetTotalViewingHours()              => _repository.GetTotalViewingHours();
    public int GetTotalFilmViewingHours()          => _repository.GetTotalFilmViewingHours();
    public int GetTotalSeriesViewingHours()        => _repository.GetTotalSeriesViewingHours();
    public int GetTotalShowViewingHours()          => _repository.GetTotalShowViewingHours();
    public int GetTotalCartoonViewingHours()       => _repository.GetTotalCartoonViewingHours();
    public int GetTotalCartoonSeriesViewingHours() => _repository.GetTotalCartoonSeriesViewingHours();
    public int GetTotalAnimeViewingHours()         => _repository.GetTotalAnimeViewingHours();
    
    public MovieTitleWithDurationDto? GetLongestMovie()         => _repository.GetLongestMovie();
    public MovieTitleWithDurationDto? GetLongestFilm()          => _repository.GetLongestFilm();
    public MovieTitleWithDurationDto? GetLongestSeries()        => _repository.GetLongestSeries();
    public MovieTitleWithDurationDto? GetLongestShow()          => _repository.GetLongestShow();
    public MovieTitleWithDurationDto? GetLongestCartoon()       => _repository.GetLongestCartoon();
    public MovieTitleWithDurationDto? GetLongestCartoonSeries() => _repository.GetLongestCartoonSeries();
    public MovieTitleWithDurationDto? GetLongestAnime()         => _repository.GetLongestAnime();
    
    public MovieTitleWithDurationDto? GetShortestMovie()         => _repository.GetShortestMovie();
    public MovieTitleWithDurationDto? GetShortestFilm()          => _repository.GetShortestFilm();
    public MovieTitleWithDurationDto? GetShortestSeries()        => _repository.GetShortestSeries();
    public MovieTitleWithDurationDto? GetShortestShow()          => _repository.GetShortestShow();
    public MovieTitleWithDurationDto? GetShortestCartoon()       => _repository.GetShortestCartoon();
    public MovieTitleWithDurationDto? GetShortestCartoonSeries() => _repository.GetShortestCartoonSeries();
    public MovieTitleWithDurationDto? GetShortestAnime()         => _repository.GetShortestAnime();
    
    public TagWithViewCounterDto[] GetTop10TagsByViews() => _repository.GetTop10TagsByViews();
}