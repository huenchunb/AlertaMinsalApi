using WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;
using WebApiAlertaMinsal.Application.Agresiones.Queries.GetAgresionesGeoLocation;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Agresiones : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapPost(CreateAgresion)
            .MapGet(GetAgresionesGeoLocation, "GetAgresionesGeoLocation");
    }

    private static async Task<IResult> CreateAgresion(ISender sender, CreateAgresionCommand command)
    {
        await sender.Send(command);
        return Results.Created();
    }

    private static async Task<IResult> GetAgresionesGeoLocation(ISender sender)
    {
        var response = await sender.Send(new GetAgresionesGeoLocationQuery());
        return Results.Ok(response);
    }
}
