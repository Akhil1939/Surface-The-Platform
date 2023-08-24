using System.ComponentModel.DataAnnotations;
namespace Surface.Entities.DataModels;
public class IdentityEntity<T>
{
    [Key]
    public T Id { get; set; }
}