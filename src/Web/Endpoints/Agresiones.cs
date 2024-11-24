using WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;
using WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressions;
using WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressionSummaryByDate;
using WebApiAlertaMinsal.Application.Agresiones.Queries.GetAgresionesCountByCategories;
using WebApiAlertaMinsal.Application.Agresiones.Queries.GetAgresionesGeoLocation;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Agresiones : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapPost(CreateAgresion)
            .MapGet(GetAgressions)
            .MapGet(GetAgresionesGeoLocation, "GetAgresionesGeoLocation")
            .MapGet(GetAgresionesCountByCategories, "GetAgresionesCountByCategories")
            .MapGet(GetAggressionSummaryByDate, "GetAggressionSummaryByDate");
    }

    private static async Task<IResult> GetAgressions(ISender sender)
    {
        var response = await sender.Send(new GetAggressionQuery());
        return Results.Ok(response);
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

    private static async Task<IResult> GetAgresionesCountByCategories(ISender sender)
    {
        var response = await sender.Send(new GetAgresionesCountByCategoriesQuery());
        return Results.Ok(response);
    }

    private static async Task<IResult> GetAggressionSummaryByDate(ISender sender)
    {
        var response = await sender.Send(new GetAggressionSummaryByDateQuery());
        return Results.Ok(response);
    }
}
