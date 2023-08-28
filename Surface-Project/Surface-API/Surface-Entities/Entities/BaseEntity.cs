using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface.Entities.DataModels;
public class BaseEntity<T> : TimeStampedEntity<T>
{
    public long CreatedBy { get; set; }
    public long ModifiedBy { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public virtual User? CreatedByUser { get; set; }

    [ForeignKey(nameof(ModifiedBy))]
    public virtual User? ModifiedByUser { get; set; }
}
