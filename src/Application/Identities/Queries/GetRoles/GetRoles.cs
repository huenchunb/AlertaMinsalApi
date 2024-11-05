using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Models;

namespace WebApiAlertaMinsal.Application.Identities.Queries.GetRoles;

public class GetRolesQuery : IRequest<List<RolDto>>;

public class GetRolesQueryHandler(IIdentityService identityService) : IRequestHandler<GetRolesQuery, List<RolDto>>
{
    public async Task<List<RolDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        return await identityService.GetRolesAsync(cancellationToken);
    }
}
