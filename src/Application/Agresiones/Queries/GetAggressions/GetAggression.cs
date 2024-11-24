namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressions;

public class GetAggressionQuery : IRequest<PaginatedList<AggressionDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
};

public record GetAggressionQueryHandler(IApplicationDbContext Context)
    : IRequestHandler<GetAggressionQuery, PaginatedList<AggressionDto>>
{
    public async Task<PaginatedList<AggressionDto>> Handle(GetAggressionQuery request, CancellationToken cancellationToken)
    {
        var agresiones = await Context.Agresion
            .Include(ag => ag.EstadoAgresion)
            .Include(ag => ag.TipoAgresionCategorias)
            .ThenInclude(ac => ac.CategoriaAgresion)
            .ThenInclude(ca => ca.TipoAgresion)
            .Include(ag => ag.Agresores)
            .ThenInclude(agr => agr.Comuna)
            .Include(ag => ag.AgresionTestigos)
            .ThenInclude(at => at.Testigo)
            .Select(ag => new AggressionDto
            {
                AgresionId = ag.Id,
                FechaAgresion = ag.FechaAgresion,
                EstadoAgresion = ag.EstadoAgresion.Name,
                TipoAgresion = ag.TipoAgresionCategorias
                    .Select(ac => ac.CategoriaAgresion.TipoAgresion.Name)
                    .FirstOrDefault(),
                CategoriasAgresion = ag.TipoAgresionCategorias
                    .Select(ac => ac.CategoriaAgresion.Name)
                    .ToList(),
                Agresores = ag.Agresores
                    .Select(agr => new AgresorDto
                    {
                        Id = agr.Id,
                        Name = agr.Name,
                        LastName = agr.LastName,
                        FullName = agr.FullName,
                        Rut = agr.Rut,
                        Digito = agr.Digito,
                        RutNormalized = agr.RutNormalized,
                        Direccion = agr.Direccion,
                        Comuna = agr.Comuna != null ? agr.Comuna.Name : null
                    })
                    .ToList(),
                Testigos = ag.AgresionTestigos
                    .Select(at => new TestigoDto
                    {
                        Id = at.Testigo.Id,
                        Name = at.Testigo.Name,
                        LastName = at.Testigo.LastName,
                        FullName = at.Testigo.FullName,
                        Rut = at.Testigo.Rut,
                        Digito = at.Testigo.Digito,
                        RutNormalized = at.Testigo.RutNormalized,
                        Email = at.Testigo.Email,
                        PhoneNumber = at.Testigo.PhoneNumber
                    })
                    .ToList()
            })
            .PaginatedListAsync(request.PageNumber, request.PageSize);

        return agresiones;
    }
};
