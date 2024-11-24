namespace WebApiAlertaMinsal.Domain.Entities;

public class Empleado : BasePersonEntity
{
    public string AccountId { get; set; } = string.Empty;
    public int MutualidadId { get; set; }
    public int EstamentoId { get; set; }
    public int EstablecimientoId { get; set; }
    public virtual Mutualidad Mutualidad { get; set; } = null!;
    public virtual Estamento Estamento { get; set; } = null!;
    public virtual Establecimiento Establecimiento { get; set; } = null!;
    public virtual ICollection<Agresion> Agresiones { get; set; } = [];
}
