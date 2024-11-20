using WebApiAlertaMinsal.Application.Establecimientos.Dtos;

namespace WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablecimientos;

[Authorize(Roles = Roles.Administrator)]
public class GetEstablecimientosWithPaginationQuery : IRequest<PaginatedList<EstablecimientoDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetEstablecimientosQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEstablecimientosWithPaginationQuery, PaginatedList<EstablecimientoDto>>
{
    public async Task<PaginatedList<EstablecimientoDto>> Handle(GetEstablecimientosWithPaginationQuery request,
        CancellationToken cancellationToken)
    {
        return await context.Establecimiento.OrderByDescending(x => x.Id)
            .ProjectTo<EstablecimientoDto>(mapper.ConfigurationProvider)
            .OrderBy(x => x.Name)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
