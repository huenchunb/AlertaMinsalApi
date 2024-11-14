namespace WebApiAlertaMinsal.Domain.Entities;

public class AgresionCategoria
{
    public int AgresionId { get; set; }
    public int CategoriaAgresionId { get; set; }
    public virtual Agresion Agresion { get; set; } = null!;
    public virtual CategoriaAgresion CategoriaAgresion { get; set; } = null!;
}
