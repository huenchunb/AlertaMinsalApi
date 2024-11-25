namespace WebApiAlertaMinsal.Application.Identities.Queries.GetRoles;

[Authorize]
public class GetRolesQuery : IRequest<List<RolDto>>;

public class GetRolesQueryHandler(IIdentityService identityService) : IRequestHandler<GetRolesQuery, List<RolDto>>
{
    public async Task<List<RolDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
    {
        return await identityService.GetRolesAsync(cancellationToken);
    }
}
