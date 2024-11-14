using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Agresion> Agresiones { get; }
    DbSet<AgresionCategoria> AgresionesCategorias { get; }
    DbSet<AgresionTestigo> AgresionesTestigos { get; }
    DbSet<Agresor> Agresores { get; }
    DbSet<CategoriaAgresion> TipoAgresionCategorias { get; }
    DbSet<ComplejidadEstablecimiento> Complejidades { get; }
    DbSet<Comuna> Comunas { get; }
    DbSet<Empleado> Empleados { get; }
    DbSet<Establecimiento> Establecimientos { get; }
    DbSet<Estamento> Estamentos { get; }
    DbSet<Mutualidad> Mutualidades { get; }
    DbSet<NivelEstablecimiento> Niveles { get; }
    DbSet<Region> Regiones { get; }
    DbSet<Testigo> Testigos { get; }
    DbSet<TipoAgresion> TiposAgresiones { get; }
    DbSet<TipoAgresor> TiposAgresores { get; }
    DbSet<TipoAtencionEstablecimiento> TiposAtenciones { get; }
    DbSet<TipoEstablecimiento> TiposEstablecimientos { get; }
    DbSet<TipoUrgenciaEstablecimiento> TiposUrgencias { get; }
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
}
