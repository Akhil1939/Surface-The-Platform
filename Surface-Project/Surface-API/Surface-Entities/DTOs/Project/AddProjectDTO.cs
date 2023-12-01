

namespace Surface_Entities.DTOs.Project
{
    public class AddProjectDTO
    {
       
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? RepoLink { get; set; }
        public double Budget { get; set; } 

        //team info
        public string[] Teams {  get; set; } = Array.Empty<string>();
        

        //update status using different call

    }
}
