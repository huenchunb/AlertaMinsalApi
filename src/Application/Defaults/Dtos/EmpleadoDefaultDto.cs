namespace Microsoft.Extensions.DependencyInjection.Defaults.Dtos;

public class EmpleadoDefaultDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public int EstablecimientoId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Empleado, EmpleadoDefaultDto>();
        }
    }
}
