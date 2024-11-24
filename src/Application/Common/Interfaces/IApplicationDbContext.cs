using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Agresion> Agresion { get; }
    DbSet<AgresionCategoria> AgresionCategoria { get; }
    DbSet<AgresionTestigo> AgresionTestigo { get; }
    DbSet<Agresor> Agresor { get; }
    DbSet<CategoriaAgresion> CategoriaAgresion { get; }
    DbSet<ComplejidadEstablecimiento> ComplejidadEstablecimiento { get; }
    DbSet<Comuna> Comuna { get; }
    DbSet<Empleado> Empleado { get; }
    DbSet<Establecimiento> Establecimiento { get; }
    DbSet<Estamento> Estamento { get; }
    DbSet<Mutualidad> Mutualidad { get; }
    DbSet<NivelEstablecimiento> NivelEstablecimiento { get; }
    DbSet<Region> Region { get; }
    DbSet<Testigo> Testigo { get; }
    DbSet<TipoAgresion> TipoAgresion { get; }
    DbSet<TipoAgresor> TipoAgresor { get; }
    DbSet<TipoAtencionEstablecimiento> TipoAtencionEstablecimiento { get; }
    DbSet<TipoEstablecimiento> TipoEstablecimiento { get; }
    DbSet<TipoUrgenciaEstablecimiento> TipoUrgenciaEstablecimiento { get; }
    DbSet<TodoList> TodoList { get; }
    DbSet<TodoItem> TodoItem { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
}
