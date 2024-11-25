namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressionsSummary;

public class EstablishmentSummaryDto
{
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
public class GetAggresionsSummaryResponseDto
{
    public int AttacksReported { get; set; }
    public int ApprovedAttacks { get; set; }
    public EstablishmentSummaryDto PhysicalEstablishment { get; set; } = null!;
    public EstablishmentSummaryDto VerbalEstablishment { get; set; } = null!;
};

[Authorize]
public record GetAggresionsSummaryQuery
    : IRequest<GetAggresionsSummaryResponseDto>;

public class GetAggresionsSummaryQueryHandler(IApplicationDbContext context)
    : IRequestHandler<GetAggresionsSummaryQuery, GetAggresionsSummaryResponseDto>
{
    public async Task<GetAggresionsSummaryResponseDto> Handle(GetAggresionsSummaryQuery request, CancellationToken cancellationToken)
    {
        var attacksReported = await context.Agresion
            .CountAsync(a => a.EstadoAgresionId == 1);

        var approvedAttacks = await context.Agresion
            .CountAsync(a => a.EstadoAgresionId == 2);

        var physicalEstablishment = await context.Agresion
            .Where(a => a.TipoAgresionCategorias.Any(ac => ac.CategoriaAgresion.TipoAgresion.Id == (int)EnumTipoAgresion.Fisica))
            .GroupBy(a => a.Empleado.Establecimiento)
            .Select(g => new EstablishmentSummaryDto
            {
                Name = g.Key.Name,
                Quantity = g.Count()
            })
            .OrderByDescending(e => e.Quantity)
            .FirstOrDefaultAsync();

        var verbalEstablishment = await context.Agresion
            .Where(a => a.TipoAgresionCategorias.Any(ac => ac.CategoriaAgresion.TipoAgresion.Id == (int)EnumTipoAgresion.Verbal))
            .GroupBy(a => a.Empleado.Establecimiento)
            .Select(g => new EstablishmentSummaryDto
            {
                Name = g.Key.Name,
                Quantity = g.Count()
            })
            .OrderByDescending(e => e.Quantity)
            .FirstOrDefaultAsync();

        return new GetAggresionsSummaryResponseDto
        {
            AttacksReported = attacksReported,
            ApprovedAttacks = approvedAttacks,
            PhysicalEstablishment = physicalEstablishment!,
            VerbalEstablishment = verbalEstablishment!
        };
    }
}
