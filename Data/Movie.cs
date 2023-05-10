using System.ComponentModel.DataAnnotations;

namespace MovieReviewLib.Data;

public class Movie
{
    public int Id { get; set; }
    
    public bool WatchLater { get; set; }
    
    [Required(ErrorMessage = "Отсутствует обложка!")]
    public string PosterPath { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Отсутствует тип фильма!")]
    public MovieType? Type { get; set; }
    
    [Required(ErrorMessage = "Название фильма не может быть пустым!")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Год выпуска не может быть пустым!")]
    [Range(1000, 9999, ErrorMessage = "Значение года должно иметь длину 4 символа!")]
    public int? ReleaseYear { get; set; }
    
    [Required(ErrorMessage = "Длительность не может быть пустой!")]
    [Range(1, int.MaxValue, ErrorMessage = "Длительность не может быть меньше одной минуты!")]
    public int? Duration { get; set; }
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать жанр!")]
    public List<Genre> Genres { get; set; } = new();
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать режиссер!")]
    public List<Director> Directors { get; set; } = new();
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать сценарист!")]
    public List<Writer> Writers { get; set; } = new();
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать композитор!")]
    public List<Compositor> Compositors { get; set; } = new();
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать актер!")]
    public List<Actor> Actors { get; set; } = new();
    
    [Required(ErrorMessage = "Отсутствует оценка!")]
    public int? Score { get; set; }
    
    public string Note { get; set; } = string.Empty;
    
    public DateTime? PublishDate { get; set; }
}