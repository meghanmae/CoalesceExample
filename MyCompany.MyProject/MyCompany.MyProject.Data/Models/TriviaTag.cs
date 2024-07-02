namespace MyCompany.MyProject.Data.Models;
public class TriviaTag
{
    public int TriviaTagId { get; set; }

    [Required]
    public required string Name { get; set; }
}
