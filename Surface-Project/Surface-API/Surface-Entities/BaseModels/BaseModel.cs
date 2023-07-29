using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surface_Entities.BaseModels
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("created_by")]
        public int CreatedBy { get; set; }
        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [Column("modified_at")]
        public DateTimeOffset? ModifiedAt { get; set; }

    }
}
