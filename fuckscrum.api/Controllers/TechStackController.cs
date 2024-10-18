using fuckscrum.api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fuckscrum.api.Controllers;

[ApiController]
[Route("api/techstack")]
public class TechStackController : ControllerBase
{
    private readonly fuckscrumContext _context;
    public TechStackController(fuckscrumContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<List<TechnologyModel>>> ListAllTechnologies()
    {
        var techList = await _context.TechStack.ToListAsync();
        return Ok(techList);
    }
}