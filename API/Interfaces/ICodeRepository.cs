using API.DTOs;
using API.Models;

namespace API.Interfaces;

public interface ICodeRepository
{
    Task<IEnumerable<CodePart>> GetCodePartsAsync();
    Task<CodePart> GetCodePartByIdAsync(int id);
    Task AddCodePartAsync(NewCodePartDto codePart);
    Task DeleteCodePartAsync(int id);
    Task<bool> CompleteAsync();
}