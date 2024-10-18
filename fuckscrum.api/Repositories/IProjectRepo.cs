using fuckscrum.api.Data;

public interface IProjectRepo
{
    Task<List<ProjectModel>> GetAllAsync();
    Task<ProjectModel?> GetSingleByIdAsync(int id);
    Task<ProjectModel?> GetSingleByTitleAsync(string title);
    Task AddProjectAsync(ProjectModel project);
    Task UpdateAsync(ProjectModel project);
    Task DeleteAsync(int id);
}