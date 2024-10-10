using Microsoft.AspNetCore.Http.Features;

public class ProjectModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? TechStack { get; set; }
    public int Progress { get; set; }
    public List<FeatureModel>? Features { get; set; }
}