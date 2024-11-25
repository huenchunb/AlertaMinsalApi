namespace WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleadoByEmail;

public record GetEmpleadoByEmailQuery(string Email) : IRequest<EmpleadoDto>;

public class GetEmpleadoByEmailQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEmpleadoByEmailQuery, EmpleadoDto>
{
    public async Task<EmpleadoDto> Handle(GetEmpleadoByEmailQuery request, CancellationToken cancellationToken)
    {
        var entity = await context.Empleado
            .ProjectTo<EmpleadoDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);

        Guard.Against.NotFound(request.Email, entity);

        return entity;
    }
}
