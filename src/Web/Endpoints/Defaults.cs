using WebApiAlertaMinsal.Application.Defaults.Queries.GetDefaults;

namespace WebApiAlertaMinsal.Web.Endpoints;

public class Defaults : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetDefaults);
    }

    private static async Task<GetDefaultsResponseDto> GetDefaults(ISender sender)
    {
        return await sender.Send(new GetDefaultsQuery());
    }
}
