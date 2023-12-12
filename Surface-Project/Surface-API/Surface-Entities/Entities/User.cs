using surface.Entities.DataModels;
using Surface_Entities.Entities;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class User : TimeStampedEntity<long>
{
    public string Email { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public string? Salt { get; set; }
    public byte LoginProviderId { get; set; }
    public byte StatusId { get; set; }
    public byte AccessFailedCount { get; set; }

    public DateTime? LockedOutEndDate { get; set; }
    public string? Avatar { get; set; } = string.Empty;

    public string? Token { get; set; }
    [ForeignKey(nameof(LoginProviderId))]
    public virtual LoginProvider LoginProvider { get; } = null!;
    [ForeignKey(nameof(StatusId))]
    public virtual Status Status { get; } = null!;

    public virtual ICollection<TeamMember> TeamMembers { get; set; }


}
