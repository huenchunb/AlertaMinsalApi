namespace WebApiAlertaMinsal.Domain.Entities;

public class Region(string name) : BaseAuditableEntity
{
    public string Name { get; set; } = name;
    public virtual ICollection<Comuna> Comunas { get; set; } = [];
}
