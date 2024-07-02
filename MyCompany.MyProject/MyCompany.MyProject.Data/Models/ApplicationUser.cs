using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class ApplicationUser : OrganizationBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ApplicationUserId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required string Email { get; set; }
}
