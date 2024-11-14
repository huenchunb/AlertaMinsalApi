namespace WebApiAlertaMinsal.Domain.Entities;

public class CategoriaAgresion : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public int TipoAgresionId { get; set; }
    public virtual TipoAgresion TipoAgresion { get; set; } = null!;
}
