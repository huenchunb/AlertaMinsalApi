using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Identities.Queries.GetRoles;

[Authorize(Roles = Roles.Administrator)]
public class GetRolesQuery : IRequest<List<RolDto>>;

public class GetRolesQueryHandler(IIdentityService identityService) : IRequestHandler<GetRolesQuery, List<RolDto>>
{
    public async Task<List<RolDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        return await identityService.GetRolesAsync(cancellationToken);
    }
}
