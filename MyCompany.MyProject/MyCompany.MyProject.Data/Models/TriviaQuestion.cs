using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class TriviaQuestion : EventBase
{
    public int TriviaQuestionId { get; set; }

    [Required]
    public required string Text { get; set; }

    public ICollection<TriviaAnswer> Answers { get; set; } = [];

    [ManyToMany(nameof(TriviaQuestionTag.TriviaTag))]
    public ICollection<TriviaQuestionTag> QuestionTags { get; set; } = [];

    public class TriviaQuestionsByEventDataSource(CrudContext<AppDbContext> context) : StandardDataSource<TriviaQuestion, AppDbContext>(context)
    {
        [Coalesce]
        public string? EventId { get; set; }

        public override IQueryable<TriviaQuestion> GetQuery(IDataSourceParameters parameters)
        {
            return base.GetQuery(parameters)
                .Include(q => q.Answers)
                .Where(q => q.EventId == EventId);
        }
    }
}
