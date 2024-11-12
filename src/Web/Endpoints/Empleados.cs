using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Empleados.Commands.CrearEmpleado;
using WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleado;
using WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleadoWithPagination;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Empleados : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetEmpleadoWithPagination)
            .MapGet(GetEmpleado, "{id}")
            .MapPost(CreateEmpleado);
    }

    private static async Task<PaginatedList<EmpleadoDto>> GetEmpleadoWithPagination(ISender sender,
        [AsParameters] GetEmpleadoWithPaginationQuery query)
    {
        return await sender.Send(query);
    }

    private static async Task<EmpleadoDto> GetEmpleado(ISender sender, int id)
    {
        return await sender.Send(new GetEmpleadoQuery(id));
    }

    private static async Task<IResult> CreateEmpleado(ISender sender, CreateEmpleadoCommand command)
    {
        await sender.Send(command);
        return Results.Created();
    }
}
