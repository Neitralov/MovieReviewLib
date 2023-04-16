namespace MovieReviewLib.Data;

public class Movie
{
    public int Id { get; set; }
    public bool WatchLater { get; set; }
    public string PosterPath { get; set; } = string.Empty;
    public MovieType Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    public int Duration { get; set; }
    public List<Genre> Genres { get; set; } = new();
    public List<Director> Directors { get; set; } = new();
    public List<Writer> Writers { get; set; } = new();
    public List<Compositor> Compositors { get; set; } = new();
    public List<Actor> Actors { get; set; } = new();
    public int Score { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime? PublishDate { get; set; }
}