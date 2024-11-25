namespace WebApiAlertaMinsal.Application.Establecimientos.Commands.EditEstablishment;

[Authorize]
public record EditEstablishmentCommand(
    int Id,
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
    int ComunaId
) : IRequest;

public class EditEstablishmentCommandHandler(IApplicationDbContext context)
    : IRequestHandler<EditEstablishmentCommand>
{
    public async Task Handle(EditEstablishmentCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var establishment = new Establecimiento
            {
                Id = request.Id,
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

            context.Establecimiento.Attach(establishment);
            context.Entry(establishment).State = EntityState.Modified;

            await context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception)
        {
            throw new NotFoundException(request.Id.ToString(), nameof(Establecimiento));
        }
    }
}
