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
    public List<TipoAgresionCategoriaDto> TipoAgresionesCategorias { get; set; } = [];
    public List<RolDto> Roles { get; set; } = [];
}

public record GetDefaultsQuery : IRequest<GetDefaultsResponseDto>;

public class GetDefaultsQueryHandler(IApplicationDbContext context, IIdentityService identityService, IMapper mapper)
    : IRequestHandler<GetDefaultsQuery, GetDefaultsResponseDto>
{
    public async Task<GetDefaultsResponseDto> Handle(GetDefaultsQuery request, CancellationToken cancellationToken)
    {
        var establecimientos = await context.Establecimientos
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var estamentos = await context.Estamentos
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var mutualidades = await context.Mutualidades
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var comunas = await context.Comunas
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var roles = await identityService.GetRolesAsync(cancellationToken);

        var tipoAgresiones = await context.TiposAgresiones
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var tipoAgresores = await context.TiposAgresores
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var tipoAgresionesCategorias = await context.TipoAgresionCategorias
            .ProjectTo<TipoAgresionCategoriaDto>(mapper.ConfigurationProvider)
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
            TipoAgresionesCategorias = tipoAgresionesCategorias
        };
    }
}
