namespace WebApiAlertaMinsal.Domain.Entities;

public class Estamento : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Grado { get; set; } = string.Empty;
    public virtual ICollection<Empleado> Empleados { get; set; } = [];
}
