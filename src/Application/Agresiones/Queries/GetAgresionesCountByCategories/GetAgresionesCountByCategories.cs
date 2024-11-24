namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAgresionesCountByCategories;

public record GetAgresionesCountByCategoriesQuery : IRequest<List<AgresionesCountByCategories>>;

public class GetAgresionesCountByCategoriesQueryHandler(IApplicationDbContext context)
    : IRequestHandler<GetAgresionesCountByCategoriesQuery,
        List<AgresionesCountByCategories>>
{
    public async Task<List<AgresionesCountByCategories>> Handle(GetAgresionesCountByCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        return await (from ca in context.CategoriaAgresion
            join ac in context.AgresionCategoria on ca.Id equals ac.CategoriaAgresionId
            group ac by new { ca.Id, ca.Name, ca.TipoAgresionId }
            into g
            select new AgresionesCountByCategories
            {
                Id = g.Key.Id, Name = g.Key.Name, TipoAgresionId = g.Key.TipoAgresionId, TotalAgresiones = g.Count()
            }).ToListAsync(cancellationToken);
    }
}
