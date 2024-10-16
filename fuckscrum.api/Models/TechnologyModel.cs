using System.ComponentModel.DataAnnotations;

public class TechnologyModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ProjectModel> Projects { get; set; }
}
