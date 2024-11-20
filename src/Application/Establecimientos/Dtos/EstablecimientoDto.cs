namespace WebApiAlertaMinsal.Application.Establecimientos.Dtos;

public class EstablecimientoDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string Nivel { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string StreetNumber { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public bool Urgency { get; set; }
    public string TipoUrgencia { get; set; } = string.Empty;
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Complejidad { get; set; } = string.Empty;
    public string TipoAtencion { get; set; } = string.Empty;
    public string Comuna { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Establecimiento, EstablecimientoDto>()
                .ForMember(dest => dest.Tipo, opt => opt.MapFrom(s => s.TipoEstablecimiento.Name))
                .ForMember(dest => dest.Nivel, opt => opt.MapFrom(s => s.NivelEstablecimiento.Name))
                .ForMember(dest => dest.TipoUrgencia, opt => opt.MapFrom(s => s.TipoUrgenciaEstablecimiento.Name))
                .ForMember(dest => dest.Complejidad, opt => opt.MapFrom(s => s.ComplejidadEstablecimiento.Name))
                .ForMember(dest => dest.TipoAtencion, opt => opt.MapFrom(s => s.TipoAtencionEstablecimiento.Name))
                .ForMember(dest => dest.Comuna, opt => opt.MapFrom(s => s.Comuna.Name))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(s => s.Comuna.Region.Name));
        }
    }
}
