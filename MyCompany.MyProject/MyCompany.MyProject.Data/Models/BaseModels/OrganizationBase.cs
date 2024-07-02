namespace MyCompany.MyProject.Data.Models.BaseModels;
public class OrganizationBase
{
    [Required]
    public string OrganizationId { get; set; } = null!;

    public Organization? Organization { get; set; }
}
