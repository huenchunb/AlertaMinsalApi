namespace WebApiAlertaMinsal.Application.Establecimientos.Commands.DeleteEstablishment;

[Authorize]
public record DeleteEstablishmentCommand(int Id) : IRequest;

public class DeleteEstablishmentCommandHandler(IApplicationDbContext context)
    : IRequestHandler<DeleteEstablishmentCommand>
{
    public async Task Handle(DeleteEstablishmentCommand request, CancellationToken cancellationToken)
    {
        var entity = await context.Establecimiento
            .Where(l => l.Id == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        context.Establecimiento.Remove(entity);

        await context.SaveChangesAsync(cancellationToken);
    }
}
