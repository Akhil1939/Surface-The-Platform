using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class Status : TimeStampedEntity<byte>
{
    public string Name { get; set; } = null!;
    public byte StatusGroupId { get; set; }
    [ForeignKey(nameof(StatusGroupId))]
    public virtual StatusGroup StatusGroup { get; set; } = null!;
}
