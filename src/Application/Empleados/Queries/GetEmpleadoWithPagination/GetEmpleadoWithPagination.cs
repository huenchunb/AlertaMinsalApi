using WebApiAlertaMinsal.Application.Common.Mappings;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleadoWithPagination;

[Authorize(Roles = Roles.Administrator)]
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
        return await context.Empleados
            .OrderByDescending(x => x.Created)
            .ProjectTo<EmpleadoDto>(mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
