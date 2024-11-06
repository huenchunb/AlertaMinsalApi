namespace WebApiAlertaMinsal.Domain.Entities;

public class TipoAtencionEstablecimiento(string name) : BaseAuditableEntity
{
    public string? Name { get; set; } = name;
    public virtual ICollection<Establecimiento> Establecimientos { get; set; } = [];
}
