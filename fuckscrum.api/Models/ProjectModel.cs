using System.ComponentModel.DataAnnotations;

public class ProjectModel
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<TechnologyModel>? TechStack { get; set; }
    public int Progress { get; set; }
    public ICollection<FeatureModel>? Features { get; set; }
}