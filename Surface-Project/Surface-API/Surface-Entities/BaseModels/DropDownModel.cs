using System.ComponentModel.DataAnnotations;

namespace Surface_Entities.Entities
{
    public class DropDownModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
