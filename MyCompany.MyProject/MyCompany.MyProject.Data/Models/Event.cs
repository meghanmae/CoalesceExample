using MyCompany.MyProject.Data.Models.BaseModels;

namespace MyCompany.MyProject.Data.Models;
public class Event : OrganizationBase
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EventId { get; set; } = null!;

    [Required]
    public required string Name { get; set; }

    [Required]
    public required DateTimeOffset Start { get; set; }
    public required DateTimeOffset End { get; set; }

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
    }
}
