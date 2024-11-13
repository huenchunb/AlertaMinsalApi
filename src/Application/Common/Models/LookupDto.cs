namespace WebApiAlertaMinsal.Application.Common.Models;

public class LookupDto
{
    public int Id { get; init; }

    public string? Name { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TodoList, LookupDto>();
            CreateMap<TodoItem, LookupDto>();
            CreateMap<ComplejidadEstablecimiento, LookupDto>();
            CreateMap<NivelEstablecimiento, LookupDto>();
            CreateMap<TipoAtencionEstablecimiento, LookupDto>();
            CreateMap<TipoEstablecimiento, LookupDto>();
            CreateMap<TipoUrgenciaEstablecimiento, LookupDto>();
            CreateMap<Establecimiento, LookupDto>();
            CreateMap<Estamento, LookupDto>();
            CreateMap<Mutualidad, LookupDto>();
            CreateMap<Comuna, LookupDto>();
        }
    }
}
