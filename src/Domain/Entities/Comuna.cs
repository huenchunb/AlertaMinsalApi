namespace WebApiAlertaMinsal.Domain.Entities;

public class Comuna(string name) : BaseAuditableEntity
{
    public int IdRegion { get; set; }
    public string Name { get; set; } = name;
    public virtual Region Region { get; set; } = null!;
    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = [];
}
