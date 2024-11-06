using Microsoft.Extensions.DependencyInjection.Establecimientos.Queries.GetEstablishmentLookupData;
using WebApiAlertaMinsal.Application.Common.Models;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Establecimientos : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetEstablishmentDependencies, "GetDependenciasEstablecimiento");
    }

    private static Task<LookupEstablishmentDependenciesDto> GetEstablishmentDependencies(ISender sender)
    {
        return sender.Send(new GetEstablishmentLookupDataQuery());
    }
}
