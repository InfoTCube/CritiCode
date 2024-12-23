using API.Data;
using API.DTOs;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class CodeRepository : ICodeRepository
{
    private readonly DataContext _context;
    
    public CodeRepository(DataContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<CodePart>> GetCodePartsAsync()
    {
        return await _context.CodeParts.ToListAsync();
    }

    public async Task<CodePart> GetCodePartByIdAsync(int id)
    {
        return await _context.CodeParts.FirstOrDefaultAsync(cp => cp.Id == id);
    }

    public async Task AddCodePartAsync(NewCodePartDto newCodePart)
    {
        var codePart = new CodePart()
        {
            Description = newCodePart.Description,
            Code = newCodePart.Code,
            Language = newCodePart.Language
        };
        
        await _context.CodeParts.AddAsync(codePart);
    }

    public async Task DeleteCodePartAsync(int id)
    {
        var codePart = await _context.CodeParts.FirstOrDefaultAsync(cp => cp.Id == id);
        if (codePart == null) return;
        
        _context.Remove(codePart);
    }

    public async Task<bool> CompleteAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}   