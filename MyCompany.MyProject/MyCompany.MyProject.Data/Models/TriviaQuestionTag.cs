namespace MyCompany.MyProject.Data.Models;
public class TriviaQuestionTag
{
    public int TriviaQuestionTagId { get; set; }

    [Required]
    public int TriviaQuestionId { get; set; }
    public TriviaQuestion? TriviaQuestion { get; set; }

    [Required]
    public int TriviaTagId { get; set; }
    public TriviaTag? TriviaTag { get; set; }
}
