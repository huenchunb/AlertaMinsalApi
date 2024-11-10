namespace WebApiAlertaMinsal.Domain.Entities;

public class Empleado : BasePersonEntity
{
    public string AccountId { get; set; } = string.Empty;
    public int MutualidadId { get; set; }
    public int EstamentoId { get; set; }
    public virtual Mutualidad Mutualidad { get; set; } = null!;
    public virtual Estamento Estamento { get; set; } = null!;
}
