namespace WebApiAlertaMinsal.Application.Identities.Queries.GetRolesByUserId;

[Authorize]
public record GetRolesByUserIdQuery : IRequest<List<string>>;

public class GetRolesByUserIdQueryHandler(IIdentityService identityService, IUser user)
    : IRequestHandler<GetRolesByUserIdQuery, List<string>>
{
    public async Task<List<string>> Handle(GetRolesByUserIdQuery request, CancellationToken cancellationToken)
    {
        return await identityService.GetUserRolesAsync(user.Id!);
    }
}
