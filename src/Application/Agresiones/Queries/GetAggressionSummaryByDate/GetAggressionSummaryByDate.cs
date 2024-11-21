namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressionSummaryByDate;

public record GetAggressionSummaryByDateQuery : IRequest<List<AggressionSummaryByDateDto>>;

public class GetAggressionSummaryByDateQueryHandler(IApplicationDbContext context)
    : IRequestHandler<GetAggressionSummaryByDateQuery, List<AggressionSummaryByDateDto>>
{
    public async Task<List<AggressionSummaryByDateDto>> Handle(GetAggressionSummaryByDateQuery request,
        CancellationToken cancellationToken)
    {
        var list = await (from a in context.Agresion
                join ac in context.AgresionCategoria on a.Id equals ac.AgresionId
                join ca in context.CategoriaAgresion on ac.CategoriaAgresionId equals ca.Id
                group new { a, ca } by a.FechaAgresion.Date
                into grouped
                select new
                {
                    Date = grouped.Key,
                    PhysicalAggressions = grouped.Count(g => g.ca.TipoAgresionId == 1),
                    VerbalAggressions = grouped.Count(g => g.ca.TipoAgresionId == 2)
                }
                into resultGroup
                orderby resultGroup.Date descending
                select resultGroup)
            .OrderByDescending(x => x.Date)
            .ToListAsync(cancellationToken);

        var result = list.Select(dto => new AggressionSummaryByDateDto
            {
                Date = dto.Date.ToString("yyyy-MM-dd"),
                PhysicalAggressions = dto.PhysicalAggressions,
                VerbalAggressions = dto.VerbalAggressions
            })
            .ToList();

        return result;
    }
}
