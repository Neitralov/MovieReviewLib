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
    
    public MovieTitleWithScoreDto[] GetTop10FilmsByRaiting()         => _repository.GetTop10FilmsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10SeriesByRaiting()        => _repository.GetTop10SeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10ShowsByRaiting()         => _repository.GetTop10ShowsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonsByRaiting()      => _repository.GetTop10CartoonsByRaiting();
    public MovieTitleWithScoreDto[] GetTop10CartoonSeriesByRaiting() => _repository.GetTop10CartoonSeriesByRaiting();
    public MovieTitleWithScoreDto[] GetTop10AnimeByRaiting()         => _repository.GetTop10AnimeByRaiting();
    
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

    public string GetTotalViewingHours()              => GetFormattedViewingHours(_repository.GetTotalViewingHours());
    public string GetTotalFilmViewingHours()          => GetFormattedViewingHours(_repository.GetTotalFilmViewingHours());
    public string GetTotalSeriesViewingHours()        => GetFormattedViewingHours(_repository.GetTotalSeriesViewingHours());
    public string GetTotalShowViewingHours()          => GetFormattedViewingHours(_repository.GetTotalShowViewingHours());
    public string GetTotalCartoonViewingHours()       => GetFormattedViewingHours(_repository.GetTotalCartoonViewingHours());
    public string GetTotalCartoonSeriesViewingHours() => GetFormattedViewingHours(_repository.GetTotalCartoonSeriesViewingHours());
    public string GetTotalAnimeViewingHours()         => GetFormattedViewingHours(_repository.GetTotalAnimeViewingHours());

    public string GetLongestMovie()         => GetFormattedMovieTitleWithDuration(_repository.GetLongestMovie());
    public string GetLongestFilm()          => GetFormattedMovieTitleWithDuration(_repository.GetLongestFilm());
    public string GetLongestSeries()        => GetFormattedMovieTitleWithDuration(_repository.GetLongestSeries());
    public string GetLongestShow()          => GetFormattedMovieTitleWithDuration(_repository.GetLongestShow());
    public string GetLongestCartoon()       => GetFormattedMovieTitleWithDuration(_repository.GetLongestCartoon());
    public string GetLongestCartoonSeries() => GetFormattedMovieTitleWithDuration(_repository.GetLongestCartoonSeries());
    public string GetLongestAnime()         => GetFormattedMovieTitleWithDuration(_repository.GetLongestAnime());

    public string GetShortestMovie()         => GetFormattedMovieTitleWithDuration(_repository.GetShortestMovie());
    public string GetShortestFilm()          => GetFormattedMovieTitleWithDuration(_repository.GetShortestFilm());
    public string GetShortestSeries()        => GetFormattedMovieTitleWithDuration(_repository.GetShortestSeries());
    public string GetShortestShow()          => GetFormattedMovieTitleWithDuration(_repository.GetShortestShow());
    public string GetShortestCartoon()       => GetFormattedMovieTitleWithDuration(_repository.GetShortestCartoon());
    public string GetShortestCartoonSeries() => GetFormattedMovieTitleWithDuration(_repository.GetShortestCartoonSeries());
    public string GetShortestAnime()         => GetFormattedMovieTitleWithDuration(_repository.GetShortestAnime());
    
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