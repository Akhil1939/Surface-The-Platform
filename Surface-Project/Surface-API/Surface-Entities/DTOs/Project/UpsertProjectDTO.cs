

namespace Surface_Entities.DTOs.Project
{
    public class UpsertProjectDTO
    {
        public long Id { get; set; } = 0;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string? RepoLink { get; set; }
        public double Budget { get; set; } 

        //update status using different call

    }
}
