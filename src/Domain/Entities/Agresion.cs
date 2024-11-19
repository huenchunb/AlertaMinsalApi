namespace WebApiAlertaMinsal.Domain.Entities;

public class Agresion : BaseAuditableEntity
{
    public DateTime FechaAgresion { get; set; }
    public int EmpleadoId { get; set; }
    public int? EstadoAgresionId { get; set; }
    public virtual Empleado Empleado { get; set; } = null!;
    public virtual EstadoAgresion EstadoAgresion { get; set; } = null!;
    public virtual ICollection<AgresionTestigo> AgresionTestigos { get; set; } = [];
    public virtual ICollection<AgresionCategoria> TipoAgresionCategorias { get; set; } = [];
    public virtual ICollection<Agresor> Agresores { get; set; } = [];
}
