using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Application.Common.Models;
using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Entities;

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
    int ComunaId) : IRequest<EstablishmentDto>;

public class CreateEstablishmentCommandHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<CreateEstablishmentCommand, EstablishmentDto>
{
    public async Task<EstablishmentDto> Handle(CreateEstablishmentCommand request, CancellationToken cancellationToken)
    {
        var entity = new Establecimiento(request.Name, request.TipoEstablecimientoId, request.NivelEstablecimientoId,
            request.Address, request.StreetNumber, request.PhoneNumber, request.Urgency,
            request.TipoUrgenciaEstablecimientoId,
            request.Longitude, request.Latitude, request.ComplejidadEstablecimientoId,
            request.TipoAtencionEstablecimientoId, request.ComunaId) { Id = request.Code };

        await context.Establecimientos.AddAsync(entity, cancellationToken);

        await context.SaveChangesAsync(cancellationToken);

        return mapper.Map<EstablishmentDto>(entity);
    }
}
