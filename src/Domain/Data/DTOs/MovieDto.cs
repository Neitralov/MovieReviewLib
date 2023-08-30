namespace Domain.Data.DTOs;

public class MovieDto
{
    public int MovieId { get; set; }
    public string PosterPath { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int? ReleaseYear { get; set; }
    public int? Score { get; set; }
}