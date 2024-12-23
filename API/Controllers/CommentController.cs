using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetCommentById(int id)
    {
        return NotFound();
    }

    [Authorize]
    [HttpPost]
    public IActionResult AddCommentPart(int reviewId)
    {
        return NotFound();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult DeleteComment(int id)
    {
        return NotFound();
    }
}