using Microsoft.AspNetCore.Mvc;

namespace fuckscrum.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    [HttpGet]
    public ActionResult List()
    {
        return Ok(new { message = "Show all proj" });
    }

    [HttpGet("{id}")]
    public ActionResult GetProjectById(int id)
    {
        return Ok(new { message = $"Show proj w id {id}" });
    }

    [HttpGet("title/{title}")]
    public ActionResult GetProjectByTitle(string title)
    {
        return Ok(new { message = $"Show proj w title {title}" });
    }

    [HttpPost("{id}")]
    public ActionResult CreateProject()
    {
        return Created(nameof(GetProjectById), new { message = "createproject called" });
    }

}