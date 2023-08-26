using surface.Entities.DataModels;

namespace Surface.Entities.DataModels;
public class UserRole : TimeStampedEntity<byte>
{
    public string Name { get; set; } = null!;
}