using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class Language : TimeStampedEntity<byte>
{
    public string EnglishName { get; set; } = null!;
    public string FrenchName { get; set; } = null!;
    public byte StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public virtual Status Status { get; set; } = null!;
}
