using Surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface_Entities.Entities
{
    public class CustomerStory:BaseEntity<long>
    {
        public string Name { get; set; } = null!;
        public string Story { get; set; } = null!;
        public int Index { get; set; }
        public long ProjectId { get; set; }
        public byte StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public virtual Status Status { get; } = null!;
        [ForeignKey(nameof(ProjectId))]
        public virtual Project Project { get; } = null!;

    }
}
