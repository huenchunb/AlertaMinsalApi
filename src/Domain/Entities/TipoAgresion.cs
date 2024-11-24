namespace WebApiAlertaMinsal.Domain.Entities;

public class TipoAgresion : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public virtual ICollection<CategoriaAgresion> CategoriasAgresion { get; set; } = [];
}
