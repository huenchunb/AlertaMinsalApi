namespace WebApiAlertaMinsal.Domain.Entities;

public class TipoAgresor : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<Agresor> Agresores { get; set; } = [];
}
