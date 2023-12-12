using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_Entities.DTOs.Project
{
    public class UpdateProjectDetailsDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime ActualStartDate { get; set; }
        public DateTime ActualEndEndDate { get; set; }
        public string? RepoLink { get; set; }
        public double Budget { get; set; }
    }
}
