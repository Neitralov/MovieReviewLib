namespace Domain.Services;

public class StatisticsService
{
    private readonly IStatisticsRepository _repository;

    public StatisticsService(IStatisticsRepository repository)
    {
        _repository = repository;
    }
    
    public string GetNumberOfWatchedMovies()        => _repository.GetNumberOfWatchedMovies().ToString();
    public string GetNumberOfWatchedFilms()         => _repository.GetNumberOfWatchedFilms().ToString();
    public string GetNumberOfWatchedSeries()        => _repository.GetNumberOfWatchedSeries().ToString();
    public string GetNumberOfWatchedShows()         => _repository.GetNumberOfWatchedShows().ToString();
    public string GetNumberOfWatchedCartoons()      => _repository.GetNumberOfWatchedCartoons().ToString();
    public string GetNumberOfWatchedCartoonSeries() => _repository.GetNumberOfWatchedCartoonSeries().ToString();
    public string GetNumberOfWatchedAnime()         => _repository.GetNumberOfWatchedAnime().ToString();
    
    public string GetNumberOfPostponedMovies()        => _repository.GetNumberOfPostponedMovies().ToString();
    public string GetNumberOfPostponedFilms()         => _repository.GetNumberOfPostponedFilms().ToString();
    public string GetNumberOfPostponedSeries()        => _repository.GetNumberOfPostponedSeries().ToString();
    public string GetNumberOfPostponedShows()         => _repository.GetNumberOfPostponedShows().ToString();
    public string GetNumberOfPostponedCartoons()      => _repository.GetNumberOfPostponedCartoons().ToString();
    public string GetNumberOfPostponedCartoonSeries() => _repository.GetNumberOfPostponedCartoonSeries().ToString();
    public string GetNumberOfPostponedAnime()         => _repository.GetNumberOfPostponedAnime().ToString();
    
    public MovieTitleWithScoreDto[] GetTop10FilmsByRaiting()         => _repository.GetTop10WatchedFilmsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10SeriesByRaiting()        => _repository.GetTop10WatchedSeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10ShowsByRaiting()         => _repository.GetTop10WatchedShowsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonsByRaiting()      => _repository.GetTop10WatchedCartoonsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonSeriesByRaiting() => _repository.GetTop10WatchedCartoonSeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10AnimeByRaiting()         => _repository.GetTop10WatchedAnimeByRaiting();
    
    public string GetNewestWatchedMovie()         => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedMovie());
    public string GetNewestWatchedFilm()          => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedFilm());
    public string GetNewestWatchedSeries()        => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedSeries());
    public string GetNewestWatchedShow()          => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedShow());
    public string GetNewestWatchedCartoon()       => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedCartoon());
    public string GetNewestWatchedCartoonSeries() => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedCartoonSeries());
    public string GetNewestWatchedAnime()         => GetFormattedTitleWithReleaseYear(_repository.GetNewestWatchedAnime());

    public string GetOldestWatchedMovie()         => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedMovie());
    public string GetOldestWatchedFilm()          => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedFilm());
    public string GetOldestWatchedSeries()        => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedSeries());
    public string GetOldestWatchedShow()          => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedShow());
    public string GetOldestWatchedCartoon()       => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedCartoon());
    public string GetOldestWatchedCartoonSeries() => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedCartoonSeries());
    public string GetOldestWatchedAnime()         => GetFormattedTitleWithReleaseYear(_repository.GetOldestWatchedAnime());

    public string GetTotalWatchedViewingHours()              => GetFormattedViewingHours(_repository.GetTotalWatchedViewingHours());
    public string GetTotalWatchedFilmViewingHours()          => GetFormattedViewingHours(_repository.GetTotalWatchedFilmViewingHours());
    public string GetTotalWatchedSeriesViewingHours()        => GetFormattedViewingHours(_repository.GetTotalWatchedSeriesViewingHours());
    public string GetTotalWatchedShowViewingHours()          => GetFormattedViewingHours(_repository.GetTotalWatchedShowViewingHours());
    public string GetTotalWatchedCartoonViewingHours()       => GetFormattedViewingHours(_repository.GetTotalWatchedCartoonViewingHours());
    public string GetTotalWatchedCartoonSeriesViewingHours() => GetFormattedViewingHours(_repository.GetTotalWatchedCartoonSeriesViewingHours());
    public string GetTotalWatchedAnimeViewingHours()         => GetFormattedViewingHours(_repository.GetTotalWatchedAnimeViewingHours());

    public string GetLongestWatchedMovie()         => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedMovie());
    public string GetLongestWatchedFilm()          => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedFilm());
    public string GetLongestWatchedSeries()        => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedSeries());
    public string GetLongestWatchedShow()          => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedShow());
    public string GetLongestWatchedCartoon()       => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedCartoon());
    public string GetLongestWatchedCartoonSeries() => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedCartoonSeries());
    public string GetLongestWatchedAnime()         => GetFormattedMovieTitleWithDuration(_repository.GetLongestWatchedAnime());

    public string GetShortestWatchedMovie()         => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedMovie());
    public string GetShortestWatchedFilm()          => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedFilm());
    public string GetShortestWatchedSeries()        => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedSeries());
    public string GetShortestWatchedShow()          => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedShow());
    public string GetShortestWatchedCartoon()       => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedCartoon());
    public string GetShortestWatchedCartoonSeries() => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedCartoonSeries());
    public string GetShortestWatchedAnime()         => GetFormattedMovieTitleWithDuration(_repository.GetShortestWatchedAnime());
    
    public TagWithViewCounterDto[] GetTop10TagsByViews() => _repository.GetTop10TagsByViews();

    private string GetFormattedTitleWithReleaseYear(MovieTitleWithReleaseYearDto? data)
    {
        return data is not null
            ? $"{data.Title} ({data.ReleaseYear} год)"
            : "N/A";
    }

    private string GetFormattedViewingHours(int data)
    {
        string GetDaysFromHours(int hours)
        {
            string GetEndingOfTheDay(int days)
            {
                var lastDigitOfDays = days % 10;
                return lastDigitOfDays switch
                {
                    1           => "день",
                    2 or 3 or 4 => "дня",
                    _           => "дней"
                };
            }

            var days = (int)Math.Round((double)hours / 24);

            return $"{days} {GetEndingOfTheDay(days)}";
        }

        return $"{data} ({GetDaysFromHours(data)})";
    }

    private string GetFormattedMovieTitleWithDuration(MovieTitleWithDurationDto? data)
    {
        return data is not null
            ? $"{data.Title} ({data.Duration} минут)"
            : "N/A";
    }
}