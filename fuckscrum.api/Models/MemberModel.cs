using System.ComponentModel.DataAnnotations;
namespace fuckscrum.api.Models;
public class MemberModel
{
    [Key]
    public int Id { get; set; }
    public string? Alias { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public MemberRole Role { get; set; }

    public ICollection<ProjectModel>? Projects { get; set; }
    public ICollection<FeatureModel>? Features { get; set; }
}
