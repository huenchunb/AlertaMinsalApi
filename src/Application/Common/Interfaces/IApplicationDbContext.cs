using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<ComplejidadEstablecimiento> Complejidades { get; }
    DbSet<Comuna> Comunas { get; }
    DbSet<Empleado> Empleados { get; }
    DbSet<Establecimiento> Establecimientos { get; }
    DbSet<Estamento> Estamentos { get; }
    DbSet<Mutualidad> Mutualidades { get; }
    DbSet<NivelEstablecimiento> Niveles { get; }
    DbSet<Region> Regiones { get; }
    DbSet<TipoAtencionEstablecimiento> TiposAtenciones { get; }
    DbSet<TipoEstablecimiento> TiposEstablecimientos { get; }
    DbSet<TipoUrgenciaEstablecimiento> TiposUrgencias { get; }
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
}
