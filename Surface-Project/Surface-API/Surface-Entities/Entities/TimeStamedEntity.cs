using Surface.Common.Utils;
using Surface.Entities.DataModels;

namespace surface.Entities.DataModels;
public class TimeStampedEntity<T> : IdentityEntity<T>
{
    public DateTimeOffset CreatedOn { get; set; } = DateTimeProvider.GetCurrentDateTime();
    public DateTimeOffset ModifiedOn { get; set; } = DateTimeProvider.GetCurrentDateTime();
}