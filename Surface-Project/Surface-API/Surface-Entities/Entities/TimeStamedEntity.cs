using Surface.Common.Utils;
using Surface.Entities.DataModels;

namespace surface.Entities.DataModels;
public class TimeStampedEntity<T> : IdentityEntity<T>
{
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;
}