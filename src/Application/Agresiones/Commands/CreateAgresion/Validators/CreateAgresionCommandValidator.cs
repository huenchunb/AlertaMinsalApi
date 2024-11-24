using WebApiAlertaMinsal.Application.Agresiones.Dtos;

namespace WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;

public class CreateAgresionCommandValidator : AbstractValidator<CreateAgresionCommand>
{
    public CreateAgresionCommandValidator(IValidator<AgresorCreateDto> agresorValidator,
        IValidator<TestigoCreateDto> testigoValidator)
    {
        RuleFor(x => x.FechaAgresion)
            .Must(BeAValidDate)
            .WithMessage("La fecha de agresión no es válida");

        RuleForEach(x => x.Agresores)
            .SetValidator(agresorValidator);

        RuleForEach(x => x.Testigos)
            .SetValidator(testigoValidator);
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default;
    }
}
