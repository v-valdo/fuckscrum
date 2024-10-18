using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FeatureModel
{
    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }
    public FeaturePriority Priority { get; set; }
    public string? Description { get; set; }
    public int Progress { get; set; }
    public ICollection<FeatureType>? Type { get; set; }
    public int ProjectId { get; set; }

    [ForeignKey("ProjectId")]
    public ProjectModel? Project { get; set; }

}