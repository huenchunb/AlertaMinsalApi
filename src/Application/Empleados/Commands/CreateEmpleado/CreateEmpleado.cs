using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;
using WebApiAlertaMinsal.Domain.ValueObjects;

namespace WebApiAlertaMinsal.Application.Empleados.Commands.CrearEmpleado;

[Authorize(Roles = Roles.Administrator)]
public class CreateEmpleadoCommand : IRequest
{
    public string Rut { get; set; } = string.Empty;
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; init; }
    public string? Address { get; init; }
    public string? StreetNumber { get; init; }
    public int ComunaId { get; init; }
    public string? ImageUrl { get; init; }
    public int MutualidadId { get; init; }
    public int EstamentoId { get; init; }
    public int EstablecimientoId { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CreateEmpleadoCommand, Empleado>();
        }
    }
};

public class CreatEmpleadoCommandHandler(
    IApplicationDbContext context,
    IIdentityService identityService,
    IMapper mapper)
    : IRequestHandler<CreateEmpleadoCommand>
{
    public async Task Handle(CreateEmpleadoCommand request, CancellationToken cancellationToken)
    {
        var rut = Rut.Create(request.Rut);
        Email.Create(request.Email!);
    
        var empleado = mapper.Map<Empleado>(request);
        empleado.Rut = rut.GetRutWithoutDv();
        empleado.Digito = rut.GetDv().ToString().ToUpper();
        empleado.RutNormalized = request.Rut!.ToUpper();
        empleado.FullName = $"{empleado.FirstName} {empleado.LastName}";

        (Result result, string userId) =
            await identityService.CreateUserAsync(empleado.Email, empleado.Rut, Roles.Jefatura);

        if (!result.Succeeded) throw new ValidationException("Ocurrió un error al crear el usuario");

        empleado.AccountId = userId;
        await context.Empleados.AddAsync(empleado, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}
