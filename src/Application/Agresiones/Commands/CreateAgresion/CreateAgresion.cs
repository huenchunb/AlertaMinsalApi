using WebApiAlertaMinsal.Domain.Events;

namespace WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;

[Authorize]
public class CreateAgresionCommand : IRequest
{
    public DateTime FechaAgresion { get; set; }
    public int EmpleadoId { get; set; }
    public List<int> CategoriasAgresionesId { get; set; } = [];
    public List<AgresorCreateDto> Agresores { get; set; } = null!;
    public List<TestigoCreateDto> Testigos { get; set; } = [];

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CreateAgresionCommand, Agresion>();
        }
    }
}

public class CreateAgresionCommandHandler(
    IApplicationDbContext context,
    IMapper mapper,
    IEmailService emailService,
    ITemplateRenderer templateRenderer)
    : IRequestHandler<CreateAgresionCommand>
{
    public async Task Handle(CreateAgresionCommand request, CancellationToken cancellationToken)
    {
        var agresion = mapper.Map<Agresion>(request);
        agresion.EstadoAgresionId = (int)EnumEstadoAgresion.Ingresada;
        var testigos = mapper.Map<List<Testigo>>(request.Testigos);
        var agresionCategorias = request.CategoriasAgresionesId.Select(categoriaId =>
            new AgresionCategoria { CategoriaAgresionId = categoriaId }).ToList();
        agresion.TipoAgresionCategorias = agresionCategorias;

        foreach (var agresionTestigo in testigos.Select(testigo => new AgresionTestigo { Testigo = testigo }))
        {
            agresion.AgresionTestigos.Add(agresionTestigo);
        }

        await context.Agresion.AddAsync(agresion, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        agresion.AddDomainEvent(new CreateAggresionEvent(agresion));

        var empleado = await context.Empleado
            .Where(x => x.Id == agresion.EmpleadoId)
            .FirstOrDefaultAsync(cancellationToken);

        if (empleado != null)
        {
            var model = new
            {
                name = empleado.FullName,
                message =
                    "Se ha registrado una agresión en donde has sido víctima. Recuerda revisar los antecedentes, aprobar o rechazar esta agresión."
            };
            var htmlContent = await templateRenderer.RenderTemplateAsync("EmailTemplate.sbn", model);

            await emailService.SendMailAsync(empleado.Email, "Haz denunciado una agresión que requiere tu aprobación",
                htmlContent);
        }
    }
}
