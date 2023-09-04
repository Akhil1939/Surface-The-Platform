using Surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface_Entities.Entities
{
    public class Project : BaseEntity<long>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string? RepoLink { get; set; }
        public Double Budget { get; set; } = 0;
        public byte StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public virtual Status Statuses { get; } = null!;

    }
}
