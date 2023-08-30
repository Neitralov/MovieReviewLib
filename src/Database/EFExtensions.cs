namespace Database;

public static class EfExtensions
{
    public static IQueryable<Movie> OrderMovieBy (this IQueryable<Movie> movies, SortType type)
    {
        return type switch
        {
            SortType.None                     => movies.OrderByDescending(movie => EF.Property<DateTime>(movie, "UpdatedOn")),
            SortType.FromNewToOld             => movies.OrderByDescending(movie => movie.ReleaseYear),
            SortType.FromOldToNew             => movies.OrderBy(movie => movie.ReleaseYear),
            SortType.ByIncreasingRating       => movies.OrderBy(movie => movie.Score),
            SortType.ByDescendingRating       => movies.OrderByDescending(movie => movie.Score),
            SortType.AlphabeticalOrder        => movies.OrderBy(movie => movie.Title),
            SortType.ReverseAlphabeticalOrder => movies.OrderByDescending(movie => movie.Title),
            SortType.FromShortToLong          => movies.OrderBy(movie => movie.Duration),
            SortType.FromLongToShort          => movies.OrderByDescending(movie => movie.Duration),
            _                                 => throw new ArgumentOutOfRangeException()
        };
    }
    
    public static IQueryable<Movie> FilterMovieByType (this IQueryable<Movie> movies, MovieType type)
    {
        return type switch
        {
            MovieType.All           => movies,
            MovieType.Film          => movies.Where(movie => movie.Type == MovieType.Film),
            MovieType.Series        => movies.Where(movie => movie.Type == MovieType.Series),
            MovieType.Show          => movies.Where(movie => movie.Type == MovieType.Show),
            MovieType.Cartoon       => movies.Where(movie => movie.Type == MovieType.Cartoon),
            MovieType.CartoonSeries => movies.Where(movie => movie.Type == MovieType.CartoonSeries),
            MovieType.Anime         => movies.Where(movie => movie.Type == MovieType.Anime),
            _                       => throw new ArgumentOutOfRangeException()
        };
    }
    
    public static IQueryable<Movie> FilterMovieByTag (this IQueryable<Movie> movies, string tag)
    {
        return tag switch
        {
            "all" => movies,
            _     => movies.Where(movie => movie.Tags.Select(tag => tag.Value).Any(x => x == tag))
        };
    }
    
    public static IQueryable<MovieDto> MapMoviesToDto (this IQueryable<Movie> movies)
    {
        return movies.Select(movie => new MovieDto
        {
            MovieId = movie.MovieId,
            PosterPath = movie.PosterPath,
            Title = movie.Title,
            ReleaseYear = movie.ReleaseYear,
            Score = movie.Score
        });
    }
    
    public static IQueryable<MovieTitleWithDurationDto> MapMoviesToMovieTitleWithDurationDto (this IQueryable<Movie> movies)
    {
        return movies.Select(movie => new MovieTitleWithDurationDto
        {
            Title = movie.Title,
            Duration = movie.Duration
        });
    }
    
    public static IQueryable<MovieTitleWithReleaseYearDto> MapMoviesToMovieTitleWithReleaseYearDto (this IQueryable<Movie> movies)
    {
        return movies.Select(movie => new MovieTitleWithReleaseYearDto
        {
            Title = movie.Title,
            ReleaseYear = movie.ReleaseYear
        });
    }
    
    public static IQueryable<MovieTitleWithScoreDto> MapMoviesToMovieTitleWithScoreDto (this IQueryable<Movie> movies)
    {
        return movies.Select(movie => new MovieTitleWithScoreDto
        {
            Title = movie.Title,
            Score = movie.Score
        });
    }
    
    public static IQueryable<TagWithViewCounterDto> MapTagsToTagWithViewCounterDto (this IQueryable<Tag> tags)
    {
        return tags
            .Select(tag => tag.Value)
            .GroupBy(tag => tag)
            .Select(tag => new TagWithViewCounterDto
            {
                Tag = tag.Key,
                Counter = tag.Count()
            });
    }
}