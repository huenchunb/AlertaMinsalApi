using WebApiAlertaMinsal.Application.Establecimientos.Dtos;

namespace WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentById;

public record GetEstablishmentByIdQuery(int Id) : IRequest<EstablecimientoDto>;

public class GetEstablishmentByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEstablishmentByIdQuery, EstablecimientoDto>
{
    public async Task<EstablecimientoDto> Handle(GetEstablishmentByIdQuery request, CancellationToken cancellationToken)
    {
        var establishment = await context.Establecimiento.FindAsync(new object?[] { request.Id, cancellationToken },
            cancellationToken: cancellationToken);

        Guard.Against.NotFound(request.Id, establishment);

        return mapper.Map<EstablecimientoDto>(establishment);
    }
}
