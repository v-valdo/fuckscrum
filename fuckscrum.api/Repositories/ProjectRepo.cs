
using fuckscrum.api.Data;
using Microsoft.EntityFrameworkCore;

public class ProjectRepo : IProjectRepo
{
    private readonly fuckscrumContext _context;
    public ProjectRepo(fuckscrumContext context)
    {
        _context = context;
    }
    public async Task AddProjectAsync(ProjectModel project)
    {
        await _context.AddAsync(project);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ProjectModel>> GetAllAsync()
    {
        return await _context.Projects
        .Include(p => p.Members)
        .Include(p => p.Features)
        .Include(p => p.TechStack)
        .ToListAsync();
    }

    public async Task<ProjectModel?> GetSingleByIdAsync(int id)
    {
        return await _context.Projects
            .Include(p => p.TechStack)
            .Include(p => p.Features)
            .Include(p => p.Members)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<ProjectModel?> GetSingleByTitleAsync(string title)
    {
        return await _context.Projects
            .Include(p => p.TechStack)
            .Include(p => p.Features)
            .Include(p => p.Members)
            .FirstOrDefaultAsync(p => p.Title == title);
    }

    public async Task UpdateAsync(ProjectModel project)
    {
        _context.Projects.Update(project);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project != null)
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
    }
}