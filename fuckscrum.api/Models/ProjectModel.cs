using System.ComponentModel.DataAnnotations;
using fuckscrum.api.Models;

public class ProjectModel
{
    public ProjectModel()
    {
        Category = ProjectCategory.Other;
    }

    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Progress { get; set; }
    public ProjectCategory? Category { get; set; }
    public ICollection<TechnologyModel>? TechStack { get; set; }
    public ICollection<FeatureModel>? Features { get; set; }
    public ICollection<MemberModel>? Members { get; set; }

}