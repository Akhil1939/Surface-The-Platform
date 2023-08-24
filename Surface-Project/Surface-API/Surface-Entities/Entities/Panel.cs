using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class Panel : TimeStampedEntity<byte>
{
    public string EnglishName { get; set; } = null!;
    public string FrenchName { get; set; } = null!;
    public string IconName { get; set; } = null!;
    public byte UserRoleId { get; set; }
    [ForeignKey(nameof(UserRoleId))]
    public virtual UserRole UserRole { get; set; } = null!;
}
