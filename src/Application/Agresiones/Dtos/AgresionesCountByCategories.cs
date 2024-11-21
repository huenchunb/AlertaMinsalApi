namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AgresionesCountByCategories
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TipoAgresionId { get; set; }
    public int TotalAgresiones { get; set; }
}
