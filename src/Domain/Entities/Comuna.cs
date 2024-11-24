using System.Collections;

namespace WebApiAlertaMinsal.Domain.Entities;

public class Comuna(string name, int idRegion) : BaseAuditableEntity
{
    public string Name { get; set; } = name;
    public int IdRegion { get; set; } = idRegion;
    public virtual Region Region { get; set; } = null!;
    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = [];
    public virtual ICollection<Agresor> Agresores { get; set; } = [];
    public virtual ICollection<Empleado> Empleados { get; set; } = [];
}
