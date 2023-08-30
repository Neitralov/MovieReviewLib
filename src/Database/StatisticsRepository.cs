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

    public double GetAverageMovieRating()
    {
        return _database.Movies
            .Any(movie => movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageFilmRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageSeriesRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageShowRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageCartoonRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageCartoonSeriesRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public double GetAverageAnimeRating()
    {
        return _database.Movies
            .Any(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                ? _database.Movies
                    .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
                    .Average(movie => movie.Score)
                : 0;
    }

    public MovieTitleWithScoreDto[] GetTop10MoviesByRaiting()
    {
        return _database.Movies
            .Where(movie => movie.IsWatched == true)
            .MapMoviesToMovieTitleWithScoreDto()
            .OrderByDescending(movie => movie.Score)
            .Take(10)
            .ToArray();
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

    public int GetTotalViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalFilmViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Film && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalSeriesViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Series && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalShowViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Show && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalCartoonViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Cartoon && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalCartoonSeriesViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.CartoonSeries && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public int GetTotalAnimeViewingHours()
    {
        return _database.Movies
            .Where(movie => movie.Type == MovieType.Anime && movie.IsWatched == true)
            .Select(movie => movie.Duration!.Value)
            .Sum() / MinutesInHour;
    }

    public MovieTitleWithDurationDto? GetLongestFilm()
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

    public MovieTitleWithDurationDto? GetLongestSeries()
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

    public MovieTitleWithDurationDto? GetLongestShow()
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

    public MovieTitleWithDurationDto? GetLongestCartoon()
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

    public MovieTitleWithDurationDto? GetLongestCartoonSeries()
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

    public MovieTitleWithDurationDto? GetLongestAnime()
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

    public MovieTitleWithDurationDto? GetShortestFilm()
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

    public MovieTitleWithDurationDto? GetShortestSeries()
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

    public MovieTitleWithDurationDto? GetShortestShow()
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

    public MovieTitleWithDurationDto? GetShortestCartoon()
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

    public MovieTitleWithDurationDto? GetShortestCartoonSeries()
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

    public MovieTitleWithDurationDto? GetShortestAnime()
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