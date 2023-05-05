namespace MovieReviewLib.Data;

public class Genre
{
    public int Id { get; set; }
    public string Value { get; set; } = string.Empty;
    public override string ToString() => Value;
}