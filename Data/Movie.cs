using System.ComponentModel.DataAnnotations;

namespace MovieReviewLib.Data;

public class Movie
{
    public int Id { get; set; }
    
    public bool WatchLater { get; set; }
    
    [Required(ErrorMessage = "Отсутствует обложка!")]
    public string PosterPath { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Отсутствует тип произведения!")]
    public MovieType? Type { get; set; }
    
    [Required(ErrorMessage = "Название фильма не может быть пустым!")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Год выпуска не может быть пустым!")]
    [Range(1000, 9999, ErrorMessage = "Значение года должно иметь длину 4 символа!")]
    public int? ReleaseYear { get; set; }
    
    [Required(ErrorMessage = "Длительность не может быть пустой!")]
    [Range(1, int.MaxValue, ErrorMessage = "Длительность не может быть меньше одной минуты!")]
    public int? Duration { get; set; }
    
    [MinLength(1, ErrorMessage = "У фильма не может отсутствовать тег!")]
    public List<Tag> Tags { get; set; } = new();

    public int Score { get; set; }
    
    public string Note { get; set; } = string.Empty;
    
    public DateTime? PublishDate { get; set; }
}