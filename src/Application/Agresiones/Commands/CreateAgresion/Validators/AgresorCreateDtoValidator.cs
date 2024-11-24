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
    }
}
