using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class TriviaGuess : EventBase
{
    public int TriviaGuessId { get; set; }

    [Required]
    public string ApplicationUserId { get; set; } = null!;
    public ApplicationUser? ApplicationUser { get; set; }

    [Required]
    public int TriviaAnswerId { get; set; }
    public TriviaAnswer? TriviaAnswer { get; set; }
}
