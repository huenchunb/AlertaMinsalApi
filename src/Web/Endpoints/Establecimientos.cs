using WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentById;
using WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentLookupData;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Establecimientos.Commands.CreateEstablishment;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Establecimientos : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetEstablishmentDependencies, "GetDependenciasEstablecimiento")
            .MapGet(GetEstablishmentById, "{id:int}")
            .MapPost(CreateEstablishment, "CreateEstablecimiento");
    }

    private static Task<LookupEstablishmentDependenciesDto> GetEstablishmentDependencies(ISender sender)
    {
        return sender.Send(new GetEstablishmentLookupDataQuery());
    }

    private static Task<EstablishmentDto> GetEstablishmentById(ISender sender,
        int id)
    {
        return sender.Send(new GetEstablishmentByIdQuery(id));
    }

    private static Task<EstablishmentDto> CreateEstablishment(ISender sender, CreateEstablishmentCommand command)
    {
        return sender.Send(command);
    }
}
