using surface.Entities.DataModels;
using System.ComponentModel.DataAnnotations.Schema;
namespace Surface.Entities.DataModels;
public class Panel : TimeStampedEntity<byte>
{
    public string Name { get; set; } = null!;
    public string IconName { get; set; } = null!;
   
}
