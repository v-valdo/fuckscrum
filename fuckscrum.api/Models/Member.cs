using System.ComponentModel.DataAnnotations;
namespace fuckscrum.api.Models;
public class Member
{
    [Key]
    public int Id { get; set; }
    public string? Alias { get; set; }
    public string? Name { get; set; }
    public MemberRole Role { get; set; }
    public List<ProjectModel> Projects { get; set; } = new();
    public List<FeatureModel> Features { get; set; } = new();
}
