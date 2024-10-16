using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fuckscrum.api.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectController : ControllerBase
{
    [HttpGet()]
    public ActionResult ListAllProjects()
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

    [HttpPost()]
    public ActionResult CreateProject()
    {
        return Created(nameof(GetProjectById), new { message = "createproject called" });
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProject(int id)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProject(int id)
    {
        return NoContent();
    }
}