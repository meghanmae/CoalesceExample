namespace MyCompany.MyProject.Data.Models.BaseModels;
public class EventBase
{
    [Required]
    public string EventId { get; set; } = null!;

    public Event? Event { get; set; }
}
