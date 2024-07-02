using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class Event : OrganizationBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EventId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required DateTimeOffset Start { get; set; }
    public required DateTimeOffset End { get; set; }
}
