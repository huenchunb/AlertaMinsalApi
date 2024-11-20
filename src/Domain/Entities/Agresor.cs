namespace WebApiAlertaMinsal.Domain.Entities;

public class Agresor : BaseAuditableEntity
{
    public int AgresionId { get; set; }
    public int TipoAgresorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Rut { get; set; } = string.Empty;
    public string Digito { get; set; } = string.Empty;
    public string RutNormalized { get; set; } = string.Empty;
    public string? Direccion { get; set; }
    public int? ComunaId { get; set; }
    public virtual TipoAgresor TipoAgresor { get; set; } = null!;
    public virtual Comuna? Comuna { get; set; }
    public virtual Agresion Agresion { get; set; } = null!;
}
