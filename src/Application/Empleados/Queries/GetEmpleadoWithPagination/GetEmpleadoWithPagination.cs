namespace WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleadoWithPagination;

[Authorize]
public class GetEmpleadoWithPaginationQuery : IRequest<PaginatedList<EmpleadoDto>>
{
    public int? EstablecimientoId { get; set; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetEmpleadoWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEmpleadoWithPaginationQuery, PaginatedList<EmpleadoDto>>
{
    public async Task<PaginatedList<EmpleadoDto>> Handle(GetEmpleadoWithPaginationQuery request,
        CancellationToken _)
    {
        IQueryable<Empleado> query = context.Empleado.AsQueryable();

        if (request.EstablecimientoId.HasValue)
        {
            query = query.Where(x => x.EstablecimientoId == request.EstablecimientoId);
        }

        return await query
            .OrderByDescending(x => x.Created)
            .ProjectTo<EmpleadoDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
