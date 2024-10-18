using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fuckscrum.api.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectController : ControllerBase
{
    private readonly IProjectRepo _projectRepo;
    public ProjectController(IProjectRepo projectRepo)
    {
        _projectRepo = projectRepo;
    }

    [HttpGet()]
    public async Task<ActionResult<List<ProjectModel>>> ListAllProjects()
    {
        var projects = await _projectRepo.GetAllAsync();
        return Ok(projects);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetProjectById(int id)
    {
        var project = await _projectRepo.GetSingleByIdAsync(id);
        return Ok(project);
    }

    [HttpGet("title/{title}")]
    public async Task<ActionResult> GetProjectByTitle(string title)
    {
        var project = await _projectRepo.GetSingleByTitleAsync(title);
        return Ok(project);
    }

    [HttpPost()]
    public async Task<ActionResult> CreateProject([FromBody] ProjectModel project)
    {
        await _projectRepo.AddProjectAsync(project);
        return CreatedAtAction(nameof(GetProjectById), new { id = project.Id }, project);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateProjectAsync(int id, [FromBody] ProjectModel project)
    {
        if (id != project.Id)
        {
            return BadRequest();
        }

        await _projectRepo.UpdateAsync(project);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProject(int id)
    {
        await _projectRepo.DeleteAsync(id);
        return NoContent();
    }
}