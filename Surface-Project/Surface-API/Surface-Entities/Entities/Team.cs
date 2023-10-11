using Surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface_Entities.Entities
{
    public class Team:BaseEntity<long>
    {
        public string Name { get; set; } = null!;
        public long ProjectId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public virtual Project Projects { get;} = null!;

        public ICollection<TeamMember>? TeamMembers { get; set; }

    }
}
