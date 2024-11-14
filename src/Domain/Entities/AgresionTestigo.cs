namespace WebApiAlertaMinsal.Domain.Entities;

public class AgresionTestigo
{
    public int AgresionId { get; set; }
    public int TestigoId { get; set; }
    public virtual Agresion Agresion { get; set; } = null!;
    public virtual Testigo Testigo { get; set; } = null!;
}
