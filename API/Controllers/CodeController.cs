using API.DTOs;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CodeController : ControllerBase
{
    private readonly ICodeRepository _codeRepository;

    public CodeController(ICodeRepository codeRepository)
    {
        _codeRepository = codeRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CodePart>>> GetAllCodeParts()
    {
        var codeParts = await _codeRepository.GetCodePartsAsync();
        return Ok(codeParts);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CodePart>> GetCodePartById(int id)
    {
        var codePart = await _codeRepository.GetCodePartByIdAsync(id);

        if(codePart is null)
            return NotFound();
        
        return Ok(codePart);
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult> AddCodePart(NewCodePartDto newCodePart)
    {
        await _codeRepository.AddCodePartAsync(newCodePart);
        
        if(await _codeRepository.CompleteAsync()) 
            return Created();
        
        return BadRequest();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCodePart(int id)
    {
        await _codeRepository.DeleteCodePartAsync(id);
        
        if(await _codeRepository.CompleteAsync()) 
            return NoContent();
        
        return BadRequest();
    }
}