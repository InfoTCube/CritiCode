using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReviewController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetReviewById(int id)
    {
        return NotFound();
    }

    [Authorize]
    [HttpPost]
    public IActionResult AddReviewForCodePart(int codePartId)
    {
        return NotFound();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public IActionResult DeleteReview(int id)
    {
        return NotFound();
    }
}