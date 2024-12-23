namespace API.Models;

public class Review
{
    public int Id { get; set; }
    public int CodePartId { get; set; }
    public CodePart? CodePart { get; set; }
    public ICollection<Comment>? Comments { get; set; }
}