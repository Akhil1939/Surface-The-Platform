using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface.Entities.DataModels;
public class RolePermission : TimeStampedEntity<byte>
{
    public byte UserRoleId { get; set; }
    public byte DomainModelName { get; set; }
    public bool CanAdd { get; set; }
    public bool CanEdit { get; set; }
    public bool CanDelete { get; set; }
    public bool CanList { get; set; }

    [ForeignKey(nameof(UserRoleId))]
    public UserRole UserRole { get; set; } = null!;
}