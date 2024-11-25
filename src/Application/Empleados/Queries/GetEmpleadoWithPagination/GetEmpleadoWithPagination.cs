namespace WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleadoWithPagination;

[Authorize]
public class GetEmpleadoWithPaginationQuery : IRequest<PaginatedList<EmpleadoDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetEmpleadoWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEmpleadoWithPaginationQuery, PaginatedList<EmpleadoDto>>
{
    public async Task<PaginatedList<EmpleadoDto>> Handle(GetEmpleadoWithPaginationQuery request,
        CancellationToken _)
    {
        return await context.Empleado
            .OrderByDescending(x => x.Created)
            .ProjectTo<EmpleadoDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
