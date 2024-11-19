namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAgresionesGeoLocation;

public record GetAgresionesGeoLocationQuery : IRequest<List<AgresionGeoLocationDto>>;

public class GetAgresionesGeoLocationQueryHandler(IApplicationDbContext context) :
    IRequestHandler<GetAgresionesGeoLocationQuery, List<AgresionGeoLocationDto>>
{
    public async Task<List<AgresionGeoLocationDto>> Handle(GetAgresionesGeoLocationQuery request,
        CancellationToken cancellationToken)
    {
        var query = from a in context.Establecimiento
            join b in context.Empleado on a.Id equals b.EstablecimientoId
            join c in context.Agresion on b.Id equals c.EmpleadoId
            join d in context.AgresionCategoria on c.Id equals d.AgresionId
            join e in context.CategoriaAgresion on d.CategoriaAgresionId equals e.Id
            group new { a, e } by new { a.Id, a.Name, a.Longitude, a.Latitude }
            into g
            select new AgresionGeoLocationDto
            {
                Id = g.Key.Id,
                Name = g.Key.Name,
                Longitude = g.Key.Longitude,
                Latitude = g.Key.Latitude,
                AgresionConArmaFuego = g.Sum(x => x.e.Id == 1 ? 1 : 0),
                AgresionesConArmaBlanca = g.Sum(x => x.e.Id == 2 ? 1 : 0),
                AgresionesConObjetoContundente = g.Sum(x => x.e.Id == 3 ? 1 : 0),
                AgresionesSexualesTocaciones = g.Sum(x => x.e.Id == 4 ? 1 : 0),
                AgresionesEmpujonesCombos = g.Sum(x => x.e.Id == 5 ? 1 : 0),
                AgresionesOtro = g.Sum(x => x.e.Id == 6 ? 1 : 0),
                AgresionesInfraestructura = g.Sum(x => x.e.Id == 7 ? 1 : 0),
                AgresionesSexualesLenguaje = g.Sum(x => x.e.Id == 8 ? 1 : 0),
                AgresionesAmenazas = g.Sum(x => x.e.Id == 9 ? 1 : 0),
                AgresionesInsultos = g.Sum(x => x.e.Id == 10 ? 1 : 0),
                AgresionesBurlas = g.Sum(x => x.e.Id == 11 ? 1 : 0),
                AgresionesRedesSociales = g.Sum(x => x.e.Id == 12 ? 1 : 0),
                AgresionesOtroVerbal = g.Sum(x => x.e.Id == 13 ? 1 : 0),
                TotalAgresionesFisicas = g.Sum(x => x.e.TipoAgresionId == 1 ? 1 : 0),
                TotalAgresionesVerbales = g.Sum(x => x.e.TipoAgresionId == 2 ? 1 : 0)
            };
        
        return await query.ToListAsync(cancellationToken);
    }
}
