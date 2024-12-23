using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CodeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCodeParts()
    {
        return NotFound();
    }

    [HttpGet("{id}")]
    public IActionResult GetCodePartById(int id)
    {
        return NotFound();
    }

    [Authorize]
    [HttpPost]
    public IActionResult AddCodePart()
    {
        return NotFound();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult DeleteCodePart(int id)
    {
        return NotFound();
    }
}