using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class TriviaAnswer : EventBase
{
    public int TriviaAnswerId { get; set; }

    [Required]
    public required string Text { get; set; }

    [Required]
    public bool IsCorrect { get; set; }

    [Required]
    public int TriviaQuestionId { get; set; }
    public TriviaQuestion? TriviaQuestion { get; set; }
}
