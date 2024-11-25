namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressionSummaryByDate;

[Authorize]
public record GetAggressionSummaryByDateQuery : IRequest<List<AggressionSummaryByDateDto>>;

public class GetAggressionSummaryByDateQueryHandler(IApplicationDbContext context)
    : IRequestHandler<GetAggressionSummaryByDateQuery, List<AggressionSummaryByDateDto>>
{
    public async Task<List<AggressionSummaryByDateDto>> Handle(GetAggressionSummaryByDateQuery request,
        CancellationToken cancellationToken)
    {
        var rawData = await (
            from a in context.Agresion
            join ac in context.AgresionCategoria on a.Id equals ac.AgresionId
            join ca in context.CategoriaAgresion on ac.CategoriaAgresionId equals ca.Id
            select new { a.FechaAgresion, ac.AgresionId, ca.TipoAgresionId }
        ).Distinct().ToListAsync(cancellationToken);

        var list = rawData
            .GroupBy(x => x.FechaAgresion.Date)
            .Select(group => new
            {
                Date = group.Key,
                PhysicalAggressions =
                    group.Where(g => g.TipoAgresionId == 1).Select(g => g.AgresionId).Distinct().Count(),
                VerbalAggressions = group.Where(g => g.TipoAgresionId == 2).Select(g => g.AgresionId).Distinct()
                    .Count()
            })
            .OrderByDescending(x => x.Date)
            .ToList();

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
