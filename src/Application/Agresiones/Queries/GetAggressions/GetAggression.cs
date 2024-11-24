using System.Globalization;

namespace WebApiAlertaMinsal.Application.Agresiones.Queries.GetAggressions;

public class GetAggressionQuery : IRequest<PaginatedList<AggressionDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
};

public record GetAggressionQueryHandler(IApplicationDbContext Context, IIdentityService IdentityService)
    : IRequestHandler<GetAggressionQuery, PaginatedList<AggressionDto>>
{
    public async Task<PaginatedList<AggressionDto>> Handle(GetAggressionQuery request,
        CancellationToken cancellationToken)
    {
        CultureInfo cultura = new CultureInfo("es-ES");
        
        var agresiones = await Context.Agresion
            .Include(ag => ag.Empleado)
            .ThenInclude(em => em.Comuna)
            .ThenInclude(co => co.Region)
            .Include(ag => ag.Empleado)
            .ThenInclude(em => em.Establecimiento)
            .ThenInclude(es => es.Comuna)
            .ThenInclude(es => es.Region)
            .Include(ag => ag.EstadoAgresion)
            .Include(ag => ag.EstadoAgresion)
            .Include(ag => ag.TipoAgresionCategorias)
            .ThenInclude(ac => ac.CategoriaAgresion)
            .ThenInclude(ca => ca.TipoAgresion)
            .Include(ag => ag.Agresores)
            .ThenInclude(agr => agr.Comuna)
            .Include(ag => ag.AgresionTestigos)
            .ThenInclude(at => at.Testigo)
            .Select(ag => new AggressionDto
            {
                AgresionId = ag.Id,
                FechaAgresion = ag.FechaAgresion,
                EstadoAgresion = ag.EstadoAgresion.Name,
                CreadoPor = ag.CreatedBy!,
                ActualizadoPor = ag.LastModifiedBy!,
                FechaCreacion = ag.Created,
                FechaActualizacion = ag.LastModified,
                Empleado = new AgresionEmpleadoDto
                {
                    Id = ag.EmpleadoId,
                    FullName = ag.Empleado.FullName,
                    RutNormalized = ag.Empleado.RutNormalized,
                    Email = ag.Empleado.Email,
                    PhoneNumber = ag.Empleado.PhoneNumber,
                    Comuna = ag.Empleado.Comuna.Name,
                    Region = ag.Empleado.Comuna.Region.Name
                },
                Establecimiento = new AgresionEstablecimientoDto
                {
                    Id = ag.Empleado.EstablecimientoId,
                    Name = ag.Empleado.Establecimiento.Name,
                    Address = ag.Empleado.Establecimiento.Address,
                    Comuna = ag.Empleado.Establecimiento.Comuna.Name,
                    Region = ag.Empleado.Establecimiento.Comuna.Region.Name,
                },
                TipoAgresion = ag.TipoAgresionCategorias
                    .Select(ac => ac.CategoriaAgresion.TipoAgresion.Name)
                    .FirstOrDefault(),
                CategoriasAgresion = ag.TipoAgresionCategorias
                    .Select(ac => ac.CategoriaAgresion.Name)
                    .ToList(),
                Agresores = ag.Agresores
                    .Select(agr => new AgresionAgresorDto
                    {
                        Id = agr.Id,
                        Name = agr.Name,
                        LastName = agr.LastName,
                        FullName = agr.FullName,
                        Rut = agr.Rut,
                        Digito = agr.Digito,
                        RutNormalized = agr.RutNormalized,
                        Direccion = agr.Direccion,
                        Comuna = agr.Comuna != null ? agr.Comuna.Name : null
                    })
                    .ToList(),
                Testigos = ag.AgresionTestigos
                    .Select(at => new AgresionTestigoDto
                    {
                        Id = at.Testigo.Id,
                        Name = at.Testigo.Name,
                        LastName = at.Testigo.LastName,
                        FullName = at.Testigo.FullName,
                        Rut = at.Testigo.Rut,
                        Digito = at.Testigo.Digito,
                        RutNormalized = at.Testigo.RutNormalized,
                        Email = at.Testigo.Email,
                        PhoneNumber = at.Testigo.PhoneNumber
                    })
                    .ToList()
            })
            .OrderByDescending(ag => ag.AgresionId)
            .PaginatedListAsync(request.PageNumber, request.PageSize);

        
        foreach (var aggression in agresiones.Items)
        {
            var usuarioCreacion =
                await (from empleado in Context.Empleado
                    where empleado.AccountId == aggression.CreadoPor
                    select empleado).FirstOrDefaultAsync(cancellationToken);

            var usuarioActualizacion =
                await (from empleado in Context.Empleado
                    where empleado.AccountId == aggression.ActualizadoPor
                    select empleado).FirstOrDefaultAsync(cancellationToken);

            aggression.CreadoPor = usuarioCreacion == null ? "Administrador" : usuarioCreacion.FullName;
            aggression.ActualizadoPor = usuarioActualizacion == null ? "Administrador"  : usuarioActualizacion.FullName;
            aggression.FechaAgresionNormalizada = aggression.FechaAgresion.ToString("MMMM d, yyyy", cultura);
            aggression.FechaCreacionNormalizada = aggression.FechaCreacion.ToString("MMMM d, yyyy", cultura);
            aggression.FechaActualizacionNormalizada = aggression.FechaActualizacion.ToString("MMMM d, yyyy", cultura);
        }
        
        return agresiones;
    }
};
