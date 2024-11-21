namespace WebApiAlertaMinsal.Application.Empleados.Queries.GetEmpleado;

public record GetEmpleadoQuery(int Id) : IRequest<EmpleadoDto>;

public class GetEmpleadoQueryHandler(IApplicationDbContext context, IMapper mapper)
    : IRequestHandler<GetEmpleadoQuery, EmpleadoDto>
{
    public async Task<EmpleadoDto> Handle(GetEmpleadoQuery request, CancellationToken cancellationToken)
    {
        var entity = await context.Empleado
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        Guard.Against.NotFound(request.Id!, entity);

        return mapper.Map<EmpleadoDto>(entity);
    }
}
