using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class TriviaQuestion : EventBase
{
    public int TriviaQuestionId { get; set; }

    [Required]
    public required string Text { get; set; }

    public ICollection<TriviaAnswer> Answers { get; set; } = [];
}
