namespace Surface.Entities.DataModels;
public class AuditableEntity<T> : IdentityEntity<T>
{
    public long CreatedBy { get; set; }
    public long ModifiedBy { get; set; }
    public virtual User? CreatedByUser { get; set; }
    public virtual User? ModifiedByUser { get; set; }
}