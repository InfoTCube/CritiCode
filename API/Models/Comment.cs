namespace API.Models;

public class Comment
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public int ReviewId { get; set; }
    public Review? Review { get; set; }
}