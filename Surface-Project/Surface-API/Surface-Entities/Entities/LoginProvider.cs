using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class LoginProvider : TimeStampedEntity<byte>
{
    public string Name { get; set; } = null!;
    public byte StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public virtual Status Status { get; set; } = null!;
}
