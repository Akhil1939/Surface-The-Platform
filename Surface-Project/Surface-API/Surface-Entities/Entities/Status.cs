using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_Entities.Entities
{
    [Table("status")]
    public class Status:DropDownModel
    {
        [Column("group_id")]
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual StatusGroup Group { get; set; } = null!;
    }
}
