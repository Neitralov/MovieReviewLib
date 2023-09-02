namespace Database;

public class StatisticsRepository : IStatisticsRepository
{
    private readonly DatabaseContext _database;
    private const int MinutesInHour = 60;

    public StatisticsRepository(IDbContextFactory<DatabaseContext> factory)
    {
        _database = factory.CreateDbContext();
    }

    public int GetNumberOfWatchedMovies()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true);
    }

    public int GetNumberOfWatchedFilms()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.Film);
    }

    public int GetNumberOfWatchedSeries()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.Series);
    }

    public int GetNumberOfWatchedShows()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.Show);
    }

    public int GetNumberOfWatchedCartoons()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.Cartoon);
    }

    public int GetNumberOfWatchedCartoonSeries()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.CartoonSeries);
    }

    public int GetNumberOfWatchedAnime()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == true && movie.Type == MovieType.Anime);
    }

    public int GetNumberOfPostponedMovies()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false);
    }

    public int GetNumberOfPostponedFilms()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.Film);
    }

    public int GetNumberOfPostponedSeries()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.Series);
    }

    public int GetNumberOfPostponedShows()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.Show);
    }

    public int GetNumberOfPostponedCartoons()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.Cartoon);
    }

    public int GetNumberOfPostponedCartoonSeries()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.CartoonSeries);
    }

    public int GetNumberOfPostponedAnime()
    {
        return _database.Movies
            .Count(movie => movie.IsWatched == false && movie.Type == MovieType.Anime);
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedFilmsByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedSeriesByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedShowsByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedCartoonsByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedCartoonSeriesByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithScoreDto[] GetTop10WatchedAnimeByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedMovie()
    {
        return _database.Movies
            .Any(movie => movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
            : null; 
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedFilm()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null; 
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedShow()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedCartoon()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedCartoonSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetNewestWatchedAnime()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderByDescending(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedMovie()
    {
        return _database.Movies
            .Any(movie => movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
            : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedFilm()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedShow()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedCartoon()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedCartoonSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithReleaseYearDto? GetOldestWatchedAnime()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithReleaseYearDto()
                    .OrderBy(movie => movie.ReleaseYear)
                    .FirstOrDefault()
                : null;
    }

    public int GetTotalWatchedViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedFilmViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedSeriesViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedShowViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedCartoonViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedCartoonSeriesViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalWatchedAnimeViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedMovie()
    {
        return _database.Movies
            .Any(movie => movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
            : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedFilm()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedShow()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedCartoon()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedCartoonSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetLongestWatchedAnime()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderByDescending(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedMovie()
    {
        return _database.Movies
            .Any(movie => movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
            : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedFilm()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedShow()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedCartoon()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedCartoonSeries()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public MovieTitleWithDurationDto? GetShortestWatchedAnime()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                ? _database.Movies
                    .AsNoTracking()
                    .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                    .MapMoviesToMovieTitleWithDurationDto()
                    .OrderBy(movie => movie.Duration)
                    .FirstOrDefault()
                : null;
    }

    public TagWithViewCounterDto[] GetTop10TagsByViews()
    {
        return _database.Movies
            .Where(movie => movie.IsWatched == true)
            .SelectMany(movie => movie.Tags)
            .MapTagsToTagWithViewCounterDto()
            .OrderByDescending(tag => tag.Counter)
            .Take(10)
            .ToArray();
    }
}