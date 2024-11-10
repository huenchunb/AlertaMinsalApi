using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Empleados.Commands.CrearEmpleado;

[Authorize(Roles = Roles.Administrator)]
public class CreateEmpleadoCommand : IRequest
{
    public string? Rut { get; init; }
    public string? Digito { get; init; }
    public string? RutNormalized { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; init; }
    public int PhoneNumber { get; init; }
    public string? Address { get; init; }
    public string? StreetNumber { get; init; }
    public int ComunaId { get; init; }
    public string? ImageUrl { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CreateEmpleadoCommand, Empleado>();
        }
    }
};

public class CreatEmpleadoCommandHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<CreateEmpleadoCommand>
{
    public async Task Handle(CreateEmpleadoCommand request, CancellationToken cancellationToken)
    {
        var empleado = mapper.Map<Empleado>(request);
        await context.Empleados.AddAsync(empleado, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
