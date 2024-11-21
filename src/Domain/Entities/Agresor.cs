namespace WebApiAlertaMinsal.Domain.Entities;

public class Agresor : BaseAuditableEntity
{
    public int AgresionId { get; set; }
    public int TipoAgresorId { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? FullName { get; set; }
    public string? Rut { get; set; }
    public string? Digito { get; set; }
    public string? RutNormalized { get; set; }
    public string? Direccion { get; set; }
    public int? ComunaId { get; set; }
    public virtual TipoAgresor TipoAgresor { get; set; } = null!;
    public virtual Comuna? Comuna { get; set; }
    public virtual Agresion Agresion { get; set; } = null!;
}
