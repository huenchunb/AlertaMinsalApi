using WebApiAlertaMinsal.Application.Empleados.Commands.CrearEmpleado;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Empleados : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapPost(CreateEmpleado);
    }

    private static async Task<IResult> CreateEmpleado(ISender sender, CreateEmpleadoCommand command)
    {
        await sender.Send(command);
        return Results.Created();
    }
}
