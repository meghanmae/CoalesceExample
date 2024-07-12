using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class Event : OrganizationBase
{
    // Properties
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EventId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required DateTimeOffset Start { get; set; }
    public required DateTimeOffset End { get; set; }

    public ICollection<TriviaQuestion> Questions { get; set; } = []; 

    // DataSources
    public class EventWithOrgDataSource(CrudContext<AppDbContext> context) : StandardDataSource<Event, AppDbContext>(context)
    {
        public override IQueryable<Event> GetQuery(IDataSourceParameters parameters)
        {
            return base.GetQuery(parameters)
                .Include(x => x.Organization)
                .Include(x => x.Questions);
        }
    }

    // Behaviors
    public class EventBehaviors(CrudContext<AppDbContext> context) : StandardBehaviors<Event, AppDbContext>(context)
    {
        public override ItemResult BeforeSave(SaveKind kind, Event? oldItem, Event item)
        {
            if (item.End < item.Start)
            {
                return "End date cannot be before the start date.";
            }

            return base.BeforeSave(kind, oldItem, item);
        }

        public override async Task ExecuteDeleteAsync(Event item)
        {
            var questionsForEvent = Db.TriviaQuestions.Where(q => q.EventId == item.EventId);
            Db.RemoveRange(questionsForEvent);
            Db.RemoveRange(Db.TriviaAnswers.Where(a => a.EventId == item.EventId));
            Db.RemoveRange(Db.TriviaGuess.Where(g => g.EventId == item.EventId));
            Db.RemoveRange(Db.TriviaQuestionTags
                .Where(t => questionsForEvent.Select(q => q.TriviaQuestionId).Contains(t.TriviaQuestionId)));

            GetDbSet().Remove(item);
            await Db.SaveChangesAsync();
        }
    }
}
