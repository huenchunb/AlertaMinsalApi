using Microsoft.Extensions.DependencyInjection.Identities.Queries.GetRolesByUserId;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Identities.Queries.GetRoles;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Identities : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetRolesByUserId, "GetUserRoles")
            .MapGet(GetRoles, "GetAllRoles");
    }

    private static async Task<List<RolDto>> GetRoles(ISender sender)
    {
        return await sender.Send(new GetRolesQuery());
    }

    private static async Task<List<string>> GetRolesByUserId(ISender sender)
    {
        return await sender.Send(new GetRolesByUserIdQuery());
    }
}
