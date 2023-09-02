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
    
    MovieTitleWithScoreDto[] GetTop10FilmsByRaiting();
    MovieTitleWithScoreDto[] GetTop10SeriesByRaiting();
    MovieTitleWithScoreDto[] GetTop10ShowsByRaiting();
    MovieTitleWithScoreDto[] GetTop10CartoonsByRaiting();
    MovieTitleWithScoreDto[] GetTop10CartoonSeriesByRaiting();
    MovieTitleWithScoreDto[] GetTop10AnimeByRaiting();

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

    int GetTotalViewingHours();
    int GetTotalFilmViewingHours();
    int GetTotalSeriesViewingHours();
    int GetTotalShowViewingHours();
    int GetTotalCartoonViewingHours();
    int GetTotalCartoonSeriesViewingHours();
    int GetTotalAnimeViewingHours();

    MovieTitleWithDurationDto? GetLongestMovie();
    MovieTitleWithDurationDto? GetLongestFilm();
    MovieTitleWithDurationDto? GetLongestSeries();
    MovieTitleWithDurationDto? GetLongestShow();
    MovieTitleWithDurationDto? GetLongestCartoon();
    MovieTitleWithDurationDto? GetLongestCartoonSeries();
    MovieTitleWithDurationDto? GetLongestAnime();

    MovieTitleWithDurationDto? GetShortestMovie();
    MovieTitleWithDurationDto? GetShortestFilm();
    MovieTitleWithDurationDto? GetShortestSeries();
    MovieTitleWithDurationDto? GetShortestShow();
    MovieTitleWithDurationDto? GetShortestCartoon();
    MovieTitleWithDurationDto? GetShortestCartoonSeries();
    MovieTitleWithDurationDto? GetShortestAnime();
    
    TagWithViewCounterDto[] GetTop10TagsByViews();
}