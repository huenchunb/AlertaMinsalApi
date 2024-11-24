using WebApiAlertaMinsal.Application.Establecimientos.Commands.DeleteEstablishment;
using WebApiAlertaMinsal.Application.Establecimientos.Commands.EditEstablishment;
using WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentById;
using WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablishmentLookupData;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Establecimientos.Commands.CreateEstablishment;
using WebApiAlertaMinsal.Application.Establecimientos.Dtos;
using WebApiAlertaMinsal.Application.Establecimientos.Queries.GetEstablecimientos;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Establecimientos : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetEstablecimientoWithPagination)
            .MapGet(GetEstablishmentDependencies, "/dependencies")
            .MapGet(GetEstablishmentById, "{id:int}")
            .MapPost(CreateEstablishment)
            .MapPut(EditEstablishment, "{id:int}")
            .MapDelete(DeleteEstablishment, "{id:int}");
    }

    private async static Task<PaginatedList<EstablecimientoDto>> GetEstablecimientoWithPagination(ISender sender,
        [AsParameters] GetEstablecimientosWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private async static Task<LookupEstablishmentDependenciesDto> GetEstablishmentDependencies(ISender sender)
    {
        return await sender.Send(new GetEstablishmentLookupDataQuery());
    }

    private async static Task<EstablecimientoDto> GetEstablishmentById(ISender sender,
        int id)
    {
        return await sender.Send(new GetEstablishmentByIdQuery(id));
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
