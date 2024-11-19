using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentById;

[Authorize(Roles = Roles.Administrator)]
public record GetEstablishmentByIdQuery(int Id) : IRequest<EstablishmentDto>;

public class GetEstablishmentByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEstablishmentByIdQuery, EstablishmentDto>
{
    public async Task<EstablishmentDto> Handle(GetEstablishmentByIdQuery request, CancellationToken cancellationToken)
    {
        var establishment = await context.Establecimiento.FindAsync(new object?[] { request.Id, cancellationToken },
            cancellationToken: cancellationToken);

        Guard.Against.NotFound(request.Id, establishment);

        return mapper.Map<EstablishmentDto>(establishment);
    }
}
