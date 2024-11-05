using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Identities.Queries.GetRoles;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Identities : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetRoles, "GetRoles");
    }

    public Task<List<RolDto>> GetRoles(ISender sender)
    {
        return sender.Send(new GetRolesQuery());
    }
}
