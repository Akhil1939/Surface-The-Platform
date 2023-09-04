using Surface.Entities.DataModels;

namespace Surface_Entities.Entities
{
    public class Team:BaseEntity<long>
    {
        public string Name { get; set; } = null!;


    }
}
