using System.ComponentModel.DataAnnotations;
using fuckscrum.api.Models;

public class ProjectModel
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Progress { get; set; }

    public ICollection<TechnologyModel>? TechStack { get; set; }
    public ICollection<FeatureModel>? Features { get; set; }
    public ICollection<MemberModel>? Members { get; set; }

}