namespace WebApiAlertaMinsal.Application.Establecimientos.Commands.CreateEstablishment;

[Authorize]
public record CreateEstablishmentCommand(
    int Code,
    string Name,
    int TipoEstablecimientoId,
    int NivelEstablecimientoId,
    string Address,
    string StreetNumber,
    int PhoneNumber,
    bool Urgency,
    int TipoUrgenciaEstablecimientoId,
    double Longitude,
    double Latitude,
    int ComplejidadEstablecimientoId,
    int TipoAtencionEstablecimientoId,
    int ComunaId) : IRequest<Unit>;

public class CreateEstablishmentCommandHandler(IApplicationDbContext context)
    : IRequestHandler<CreateEstablishmentCommand, Unit>
{
    public async Task<Unit> Handle(CreateEstablishmentCommand request, CancellationToken cancellationToken)
    {
        var entity = new Establecimiento
        {
            Id = request.Code,
            Name = request.Name,
            TipoEstablecimientoId = request.TipoEstablecimientoId,
            NivelEstablecimientoId = request.NivelEstablecimientoId,
            Address = request.Address,
            StreetNumber = request.StreetNumber,
            PhoneNumber = request.PhoneNumber,
            Urgency = request.Urgency,
            TipoUrgenciaEstablecimientoId = request.TipoUrgenciaEstablecimientoId,
            Longitude = request.Longitude,
            Latitude = request.Latitude,
            ComplejidadEstablecimientoId = request.ComplejidadEstablecimientoId,
            TipoAtencionEstablecimientoId = request.TipoAtencionEstablecimientoId,
            ComunaId = request.ComunaId
        };

        await context.Establecimiento.AddAsync(entity, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
