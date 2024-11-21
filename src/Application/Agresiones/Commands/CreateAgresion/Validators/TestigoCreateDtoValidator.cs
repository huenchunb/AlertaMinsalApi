using WebApiAlertaMinsal.Application.Agresiones.Dtos;
using WebApiAlertaMinsal.Domain.ValueObjects;

namespace WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;

public class TestigoCreateDtoValidator : AbstractValidator<TestigoCreateDto>
{
    private readonly IApplicationDbContext _context;

    public TestigoCreateDtoValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(a => a.Rut)
            .Must(Rut.IsValid)
            .WithMessage("El RUT '{PropertyValue}' no es válido")
            .MustAsync(BeUniqueRut)
            .WithMessage("'{PropertyName}' ya se encuentra registrado.")
            .WithErrorCode("Único");

        RuleFor(a => a.Name)
            .NotEmpty()
            .WithMessage("El nombre no puede estar vacío");

        RuleFor(a => a.LastName)
            .NotEmpty()
            .WithMessage("El apellido no puede estar vacío");

        RuleFor(a => a.Email)
            .NotEmpty()
            .WithMessage("El correo no puede estar vacío")
            .MustAsync(BeUniqueEmail)
            .WithMessage("'{PropertyName}' ya se encuentra registrado.")
            .WithErrorCode("Único");
    }

    public async Task<bool> BeUniqueEmail(string email, CancellationToken cancellationToken)
    {
        return await _context.Testigo
            .AllAsync(l => l.Email != email, cancellationToken);
    }
    
    public async Task<bool> BeUniqueRut(string rut, CancellationToken cancellationToken)
    {
        return await _context.Testigo
            .AllAsync(l => l.RutNormalized != rut, cancellationToken);
    }
}
