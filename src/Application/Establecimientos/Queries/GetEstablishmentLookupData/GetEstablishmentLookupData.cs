using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentLookupData;

[Authorize(Roles = Roles.Administrator)]
public record GetEstablishmentLookupDataQuery : IRequest<LookupEstablishmentDependenciesDto>;

public class
    GetEstablishmentLookupDataQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEstablishmentLookupDataQuery,
        LookupEstablishmentDependenciesDto>
{
    public async Task<LookupEstablishmentDependenciesDto> Handle(GetEstablishmentLookupDataQuery request,
        CancellationToken cancellationToken)
    {
        var establishmentComplexity = await context.Complejidades
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentLevel = await context.Niveles
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentAtentionType = await context.TiposAtenciones
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentType = await context.TiposEstablecimientos
            .AsNoTracking()
            .ProjectTo<LookupDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        var establishmentUgencyType = await context.TiposUrgencias
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
