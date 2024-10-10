using System.ComponentModel.DataAnnotations;

public class FeatureModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public FeaturePriority Priority { get; set; }
    public string? Description { get; set; }
    public int Progress { get; set; }
    public List<FeatureType> Type { get; set; }
    public int ProjectId { get; set; }
    public ProjectModel Project { get; set; }

}