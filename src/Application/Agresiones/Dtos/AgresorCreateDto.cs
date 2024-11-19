namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AgresorCreateDto
{
    public int TipoAgresorId { get; set; }
    public string Rut { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int ComunaId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AgresorCreateDto, Agresor>()
                .ForMember(d => d.RutNormalized, opt => opt.MapFrom(s => s.Rut))
                .ForMember(d => d.Rut, opt => opt.MapFrom(s => GetRutWithoutDv(s.Rut)))
                .ForMember(d => d.Digito, opt => opt.MapFrom(s => GetDv(s.Rut)))
                .ForMember(d => d.FullName, opt => opt.MapFrom(s => $"{s.Name} {s.LastName}"))
                .ForMember(d => d.Direccion, opt => opt.MapFrom(s => s.Address));
        }

        private static string GetRutWithoutDv(string value)
        {
            var rut = Domain.ValueObjects.Rut.Create(value);
            return rut.GetRutWithoutDv();
        }

        private static string GetDv(string value)
        {
            var rut = Domain.ValueObjects.Rut.Create(value);
            return rut.GetDv().ToString();
        }
    }
}
