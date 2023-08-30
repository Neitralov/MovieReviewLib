namespace Domain.Data;

public class Tag
{
    public int TagId { get; set; }
    public string Value { get; set; } = string.Empty;
    public override string ToString() => Value;
}