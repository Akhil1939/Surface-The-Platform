using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class User : TimeStampedEntity<long>
{
    public string Email { get; set; } = null!;
    public string? Password { get; set; }
    public string? Salt { get; set; }
    public byte UserRoleId { get; set; }
    public byte LoginProviderId { get; set; }
    public byte StatusId { get; set; }
    public byte LanguageId { get; set; }
    public byte AccessFailedCount { get; set; }
    public DateTimeOffset? LockedOutEndDate { get; set; }
    public bool MustChangePassword { get; set; }
    public string Avatar { get; set; } = null!;
    public bool IsProfileCompleted { get; set; } = false;
    
    [ForeignKey(nameof(UserRoleId))]
    public virtual UserRole UserRole { get; } = null!;
    [ForeignKey(nameof(LoginProviderId))]
    public virtual LoginProvider LoginProvider { get; } = null!;
    [ForeignKey(nameof(StatusId))]
    public virtual Status Status { get; } = null!;
    [ForeignKey(nameof(LanguageId))]
    public virtual Language Language { get; } = null!;
}
