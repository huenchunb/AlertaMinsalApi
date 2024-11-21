namespace WebApiAlertaMinsal.Application.Common.Models;

public class EmpleadoDto
{
    public int Id { get; set; }
    public string? RutNormalized { get; init; }
    public string? FullName { get; init; }
    public string? Email { get; init; }
    public int PhoneNumber { get; init; }
    public string? Address { get; init; }
    public string? StreetNumber { get; set; }
    public string? Comuna { get; init; }
    public string? Region { get; init; }
    public string? ImageUrl { get; init; }
    public string? Mutualidad { get; init; }
    public string? Estamento { get; init; }
    public string? Establecimiento { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Empleado, EmpleadoDto>()
                .ForMember(dest => dest.Address,
                    opt => opt.MapFrom(src => $"{src.Address}, {src.Comuna.Name}, {src.Comuna.Region.Name}"))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Comuna.Region.Name))
                .ForMember(dest => dest.Mutualidad, opt => opt.MapFrom(src => src.Mutualidad.Name))
                .ForMember(dest => dest.Estamento, opt => opt.MapFrom(src => src.Estamento.Name))
                .ForMember(dest => dest.Establecimiento, opt => opt.MapFrom(src => src.Establecimiento.Name))
                .ForMember(dest => dest.Comuna, opt => opt.MapFrom(src => src.Comuna.Name));
        }
    }
}
