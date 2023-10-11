using surface.Entities.DataModels;

namespace Surface.Entities.DataModels;
public class StatusGroup : TimeStampedEntity<byte>
{
    public string Name { get; set; } = null!;

    public ICollection<Status>? Statuses { get; set; }
}
