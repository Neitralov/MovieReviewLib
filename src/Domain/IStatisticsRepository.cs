namespace Domain;

public interface IStatisticsRepository
{
    int GetNumberOfWatchedMovies(); 
    int GetNumberOfWatchedFilms();  
    int GetNumberOfWatchedSeries();  
    int GetNumberOfWatchedShows();  
    int GetNumberOfWatchedCartoons();  
    int GetNumberOfWatchedCartoonSeries();  
    int GetNumberOfWatchedAnime();  
    
    int GetNumberOfPostponedMovies();  
    int GetNumberOfPostponedFilms();  
    int GetNumberOfPostponedSeries();  
    int GetNumberOfPostponedShows();  
    int GetNumberOfPostponedCartoons(); 
    int GetNumberOfPostponedCartoonSeries();  
    int GetNumberOfPostponedAnime();  
    
    MovieTitleWithScoreDto[] GetTop10WatchedFilmsByRaiting();
    MovieTitleWithScoreDto[] GetTop10WatchedSeriesByRaiting();
    MovieTitleWithScoreDto[] GetTop10WatchedShowsByRaiting();
    MovieTitleWithScoreDto[] GetTop10WatchedCartoonsByRaiting();
    MovieTitleWithScoreDto[] GetTop10WatchedCartoonSeriesByRaiting();
    MovieTitleWithScoreDto[] GetTop10WatchedAnimeByRaiting();

    MovieTitleWithReleaseYearDto? GetNewestWatchedMovie();
    MovieTitleWithReleaseYearDto? GetNewestWatchedFilm();
    MovieTitleWithReleaseYearDto? GetNewestWatchedSeries();
    MovieTitleWithReleaseYearDto? GetNewestWatchedShow();
    MovieTitleWithReleaseYearDto? GetNewestWatchedCartoon();
    MovieTitleWithReleaseYearDto? GetNewestWatchedCartoonSeries();
    MovieTitleWithReleaseYearDto? GetNewestWatchedAnime();

    MovieTitleWithReleaseYearDto? GetOldestWatchedMovie();
    MovieTitleWithReleaseYearDto? GetOldestWatchedFilm();
    MovieTitleWithReleaseYearDto? GetOldestWatchedSeries();
    MovieTitleWithReleaseYearDto? GetOldestWatchedShow();
    MovieTitleWithReleaseYearDto? GetOldestWatchedCartoon();
    MovieTitleWithReleaseYearDto? GetOldestWatchedCartoonSeries();
    MovieTitleWithReleaseYearDto? GetOldestWatchedAnime();

    int GetTotalWatchedViewingHours();
    int GetTotalWatchedFilmViewingHours();
    int GetTotalWatchedSeriesViewingHours();
    int GetTotalWatchedShowViewingHours();
    int GetTotalWatchedCartoonViewingHours();
    int GetTotalWatchedCartoonSeriesViewingHours();
    int GetTotalWatchedAnimeViewingHours();

    MovieTitleWithDurationDto? GetLongestWatchedMovie();
    MovieTitleWithDurationDto? GetLongestWatchedFilm();
    MovieTitleWithDurationDto? GetLongestWatchedSeries();
    MovieTitleWithDurationDto? GetLongestWatchedShow();
    MovieTitleWithDurationDto? GetLongestWatchedCartoon();
    MovieTitleWithDurationDto? GetLongestWatchedCartoonSeries();
    MovieTitleWithDurationDto? GetLongestWatchedAnime();

    MovieTitleWithDurationDto? GetShortestWatchedMovie();
    MovieTitleWithDurationDto? GetShortestWatchedFilm();
    MovieTitleWithDurationDto? GetShortestWatchedSeries();
    MovieTitleWithDurationDto? GetShortestWatchedShow();
    MovieTitleWithDurationDto? GetShortestWatchedCartoon();
    MovieTitleWithDurationDto? GetShortestWatchedCartoonSeries();
    MovieTitleWithDurationDto? GetShortestWatchedAnime();
    
    TagWithViewCounterDto[] GetTop10TagsByViews();
}