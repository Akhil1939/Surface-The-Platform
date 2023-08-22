using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Surface_Entities.BaseModels;

namespace Surface_Entities.Entities
{
    [Table("user")]
    public class User:BaseModel
    {
        [Column("first_name")]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;
        [Column("last_name")]
        [StringLength(100)]
        public string? LastName { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; } = null!;
        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("password")]
        [StringLength(1000)]
        public string Password { get; set; } = null!;
        [Column("login_provider_id")]
        public int LoginProviderId { get; set; }
        [Column("login_attempt")]
        public byte LoginAttempt { get; set; }
        [Column("status_id")]
        public int StatusId { get; set; }
        [Column("is_online")]
        public bool IsOnline { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; } = null!;
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; } = null!;
        [ForeignKey("LoginProviderId")]
        public virtual LoginProvider LoginProvider { get; set; } = null!;

    }
}
