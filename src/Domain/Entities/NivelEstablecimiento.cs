namespace WebApiAlertaMinsal.Domain.Entities;

public class NivelEstablecimiento(string name) : BaseAuditableEntity
{
    public string Name { get; set; } = name;
    public ICollection<Establecimiento> Establecimientos { get; set; } = [];
}
