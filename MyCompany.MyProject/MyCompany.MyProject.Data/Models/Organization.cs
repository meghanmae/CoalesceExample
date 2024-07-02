namespace MyCompany.MyProject.Data.Models;
public class Organization
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string OrganizationId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }
}
