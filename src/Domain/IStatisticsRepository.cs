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
    
    double GetAverageMovieRating();  
    double GetAverageFilmRating();  
    double GetAverageSeriesRating();  
    double GetAverageShowRating();  
    double GetAverageCartoonRating();  
    double GetAverageCartoonSeriesRating();  
    double GetAverageAnimeRating();
    
    MovieTitleWithScoreDto[] GetTop10MoviesByRaiting();

    MovieTitleWithReleaseYearDto? GetNewestWatchedFilm();
    MovieTitleWithReleaseYearDto? GetNewestWatchedSeries();
    MovieTitleWithReleaseYearDto? GetNewestWatchedShow();
    MovieTitleWithReleaseYearDto? GetNewestWatchedCartoon();
    MovieTitleWithReleaseYearDto? GetNewestWatchedCartoonSeries();
    MovieTitleWithReleaseYearDto? GetNewestWatchedAnime();

    MovieTitleWithReleaseYearDto? GetOldestWatchedFilm();
    MovieTitleWithReleaseYearDto? GetOldestWatchedSeries();
    MovieTitleWithReleaseYearDto? GetOldestWatchedShow();
    MovieTitleWithReleaseYearDto? GetOldestWatchedCartoon();
    MovieTitleWithReleaseYearDto? GetOldestWatchedCartoonSeries();
    MovieTitleWithReleaseYearDto? GetOldestWatchedAnime();

    int GetTotalViewingHours();
    int GetTotalFilmViewingHours();
    int GetTotalSeriesViewingHours();
    int GetTotalShowViewingHours();
    int GetTotalCartoonViewingHours();
    int GetTotalCartoonSeriesViewingHours();
    int GetTotalAnimeViewingHours();

    MovieTitleWithDurationDto? GetLongestFilm();
    MovieTitleWithDurationDto? GetLongestSeries();
    MovieTitleWithDurationDto? GetLongestShow();
    MovieTitleWithDurationDto? GetLongestCartoon();
    MovieTitleWithDurationDto? GetLongestCartoonSeries();
    MovieTitleWithDurationDto? GetLongestAnime();

    MovieTitleWithDurationDto? GetShortestFilm();
    MovieTitleWithDurationDto? GetShortestSeries();
    MovieTitleWithDurationDto? GetShortestShow();
    MovieTitleWithDurationDto? GetShortestCartoon();
    MovieTitleWithDurationDto? GetShortestCartoonSeries();
    MovieTitleWithDurationDto? GetShortestAnime();
    
    TagWithViewCounterDto[] GetTop10TagsByViews();
}