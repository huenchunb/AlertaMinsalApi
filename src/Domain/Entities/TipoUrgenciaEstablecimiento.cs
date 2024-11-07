namespace WebApiAlertaMinsal.Domain.Entities;

public class TipoUrgenciaEstablecimiento(string name) : BaseAuditableEntity
{
    public string Name { get; set; } = name;
    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = [];
}
