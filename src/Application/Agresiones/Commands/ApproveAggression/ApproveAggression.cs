namespace Microsoft.Extensions.DependencyInjection.Agresiones.Commands.ApproveAggression;

[Authorize]
public record ApproveAggressionCommand(int Id, EnumEstadoAgresion estado) : IRequest<int>;

public class ApproveAggressionCommandHandler(IApplicationDbContext Context)
    : IRequestHandler<ApproveAggressionCommand, int>
{
    public async Task<int> Handle(ApproveAggressionCommand request, CancellationToken cancellationToken)
    {
        var aggression = await (from query in Context.Agresion
                where query.Id == request.Id
                select query)
            .FirstOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, aggression);

        aggression.EstadoAgresionId = (int)request.estado;

        await Context.SaveChangesAsync(cancellationToken);

        return request.Id;
    }
}
