namespace WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentLookupData;

public record GetEstablishmentLookupDataQuery : IRequest<LookupEstablishmentDependenciesDto>;

public class
    GetEstablishmentLookupDataQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEstablishmentLookupDataQuery,
        LookupEstablishmentDependenciesDto>
{
    public async Task<LookupEstablishmentDependenciesDto> Handle(GetEstablishmentLookupDataQuery request,
        CancellationToken cancellationToken)
    {
        var establishmentComplexity = await context.ComplejidadEstablecimiento
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentLevel = await context.NivelEstablecimiento
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentAtentionType = await context.TipoAtencionEstablecimiento
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentType = await context.TipoEstablecimiento
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentUgencyType = await context.TipoUrgenciaEstablecimiento
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return new LookupEstablishmentDependenciesDto
        {
            EstablishmentComplexity = establishmentComplexity,
            EstablishmentLevel = establishmentLevel,
            EstablishmentAtentionType = establishmentAtentionType,
            EstablishmentType = establishmentType,
            EstablishmentUgencyType = establishmentUgencyType
        };
    }
}
