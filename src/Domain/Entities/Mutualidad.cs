namespace WebApiAlertaMinsal.Domain.Entities;

public class Mutualidad : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Empleado> Empleados { get; set; } = [];
}
