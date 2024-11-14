namespace WebApiAlertaMinsal.Application.Models;

public class TipoAgresionCategoriaDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TipoAgresionId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CategoriaAgresion, TipoAgresionCategoriaDto>();
        }
    }
}
