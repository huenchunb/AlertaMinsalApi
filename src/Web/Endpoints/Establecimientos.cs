using Microsoft.Extensions.DependencyInjection.Establecimientos.Commands.DeleteEstablishment;
using Microsoft.Extensions.DependencyInjection.Establecimientos.Commands.EditEstablishment;
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
            .MapGet(GetEstablishmentDependencies, "/dependencies")
            .MapGet(GetEstablishmentById, "{id:int}")
            .MapPost(CreateEstablishment)
            .MapPut(EditEstablishment, "{id:int}")
            .MapDelete(DeleteEstablishment, "{id:int}");
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

    private async static Task<Unit> CreateEstablishment(ISender sender, CreateEstablishmentCommand command)
    {
        return await sender.Send(command);
    }

    private async static Task<IResult> EditEstablishment(ISender sender, EditEstablishmentCommand command, int id)
    {
        if (id != command.Id) return Results.BadRequest();
        await sender.Send(command);
        return Results.NoContent();
    }

    private async static Task<IResult> DeleteEstablishment(ISender sender, int id)
    {
        await sender.Send(new DeleteEstablishmentCommand(id));
        return Results.NoContent();
    }
}
