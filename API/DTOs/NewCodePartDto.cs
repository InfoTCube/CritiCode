using API.Models;

namespace API.DTOs;

public class NewCodePartDto
{
    public required string? Description { get; set; }
    public required string? Code { get; set; }
    public required ProgrammingLanguage Language { get; set; }
}