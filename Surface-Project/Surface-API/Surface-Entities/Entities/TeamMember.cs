using surface.Entities.DataModels;
using Surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface_Entities.Entities
{
    public class TeamMember:TimeStampedEntity<long>
    {
        public long TeamId { get; set; } 
        public long UserId { get; set; }
        public byte UserRoleId { get; set; }
        public byte StatusId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User Users { get; } = null!;
        [ForeignKey(nameof(StatusId))]
        public virtual Status Status { get; } = null!;
        [ForeignKey(nameof(TeamId))] 
        public virtual Team Teams { get; } = null!;  

    }
}
