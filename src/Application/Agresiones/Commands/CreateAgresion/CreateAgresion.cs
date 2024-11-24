using WebApiAlertaMinsal.Application.Common.Security;
using WebApiAlertaMinsal.Domain.Constants;

namespace WebApiAlertaMinsal.Application.Agresiones.Commands.CreateAgresion;

[Authorize(Roles = Roles.Jefatura)]
[Authorize(Roles = Roles.Administrator)]
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

public class CreateAgresionCommandHandler(IApplicationDbContext context, IMapper mapper)
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
    }
}
