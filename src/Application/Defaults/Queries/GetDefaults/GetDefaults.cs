using Microsoft.Extensions.DependencyInjection.Defaults.Dtos;
using WebApiAlertaMinsal.Application.Models;

namespace WebApiAlertaMinsal.Application.Defaults.Queries.GetDefaults;

public class GetDefaultsResponseDto
{
    public List<LookupDto> Establecimientos { get; set; } = [];
    public List<LookupDto> Estamentos { get; set; } = [];
    public List<LookupDto> Mutualidades { get; set; } = [];
    public List<LookupDto> Comunas { get; set; } = [];
    public List<LookupDto> TipoAgresores { get; set; } = [];
    public List<LookupDto> TipoAgresiones { get; set; } = [];
    public List<LookupDto> TipoEstablecimiento { get; set; } = [];
    public List<LookupDto> NivelEstablecimiento { get; set; } = [];
    public List<LookupDto> ComplejidadesEstablecimiento { get; set; } = [];
    public List<LookupDto> TipoAtencionEstablecimiento { get; set; } = [];
    public List<LookupDto> TipoUrgenciaEstablecimiento { get; set; } = [];
    public List<EmpleadoDefaultDto> Empleados { get; set; } = [];
    public List<TipoAgresionCategoriaDto> TipoAgresionesCategorias { get; set; } = [];
    public List<RolDto> Roles { get; set; } = [];
}

[Authorize]
public record GetDefaultsQuery : IRequest<GetDefaultsResponseDto>;

public class GetDefaultsQueryHandler(IApplicationDbContext context, IIdentityService identityService, IMapper mapper)
    : IRequestHandler<GetDefaultsQuery, GetDefaultsResponseDto>
{
    public async Task<GetDefaultsResponseDto> Handle(GetDefaultsQuery request, CancellationToken cancellationToken)
    {
        var establecimientos = await context.Establecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);

        var estamentos = await context.Estamento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var mutualidades = await context.Mutualidad
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var comunas = await context.Comuna
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);

        var roles = await identityService.GetRolesAsync(cancellationToken);

        var tipoAgresiones = await context.TipoAgresion
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var tipoAgresores = await context.TipoAgresor
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var tipoAgresionesCategorias = await context.CategoriaAgresion
            .ProjectTo<TipoAgresionCategoriaDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        var empleados = await context.Empleado
            .ProjectTo<EmpleadoDefaultDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.FullName)
            .ToListAsync(cancellationToken);

        var tipoEstablecimiento = await context.TipoEstablecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
        
        var nivelEstablecimiento = await context.NivelEstablecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);
        
        var complejidadesEstablecimiento = await context.ComplejidadEstablecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);
        
        var tipoAtencionEstablecimiento = await context.TipoAtencionEstablecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
        
        var tipoUrgenciaEstablecimiento = await context.TipoUrgenciaEstablecimiento
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);

        return new GetDefaultsResponseDto
        {
            Establecimientos = establecimientos,
            Estamentos = estamentos,
            Mutualidades = mutualidades,
            Comunas = comunas,
            Roles = roles,
            TipoAgresores = tipoAgresores,
            TipoAgresiones = tipoAgresiones,
            TipoAgresionesCategorias = tipoAgresionesCategorias,
            Empleados = empleados,
            TipoEstablecimiento = tipoEstablecimiento,
            NivelEstablecimiento = nivelEstablecimiento,
            ComplejidadesEstablecimiento = complejidadesEstablecimiento,
            TipoAtencionEstablecimiento = tipoAtencionEstablecimiento,
            TipoUrgenciaEstablecimiento = tipoUrgenciaEstablecimiento
        };
    }
}
