namespace WebApiAlertaMinsal.Domain.Entities;

public class EstadoAgresion : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Agresion> Agresiones { get; set; } = [];
}
