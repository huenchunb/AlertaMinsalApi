namespace WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;

public class AgresorCreateDtoValidator : AbstractValidator<AgresorCreateDto>
{
    private readonly IApplicationDbContext _context;

    public AgresorCreateDtoValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(a => a.TipoAgresorId)
            .GreaterThan(0)
            .WithMessage("El tipo de agresión no es válido");

        RuleFor(a => a.Rut)
            .Must(Rut.IsValid)
            .WithMessage("El RUT '{PropertyValue}' no es válido");

        RuleFor(a => a.Name)
            .NotEmpty()
            .WithMessage("El nombre no puede estar vacío");

        RuleFor(a => a.LastName)
            .NotEmpty()
            .WithMessage("El apellido no puede estar vacío");

        RuleFor(a => a.Address)
            .NotEmpty()
            .WithMessage("La dirección no puede estar vacía");

        RuleFor(a => a.ComunaId)
            .GreaterThan(0)
            .WithMessage("La comuna no es válida")
            .NotNull()
            .NotEmpty()
            .WithMessage("La campo comunaId no puede estar vacío");
    }
}
