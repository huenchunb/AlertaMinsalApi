using System.Reflection;
using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Domain.Entities;
using WebApiAlertaMinsal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApiAlertaMinsal.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
{
    public DbSet<ComplejidadEstablecimiento> Complejidades => Set<ComplejidadEstablecimiento>();
    public DbSet<Comuna> Comunas => Set<Comuna>();
    public DbSet<Establecimiento> Establecimientos => Set<Establecimiento>();
    public DbSet<NivelEstablecimiento> Niveles => Set<NivelEstablecimiento>();
    public DbSet<Region> Regiones => Set<Region>();
    public DbSet<TipoAtencionEstablecimiento> TiposAtenciones => Set<TipoAtencionEstablecimiento>();
    public DbSet<TipoEstablecimiento> TiposEstablecimientos => Set<TipoEstablecimiento>();
    public DbSet<TipoUrgenciaEstablecimiento> TiposUrgencias => Set<TipoUrgenciaEstablecimiento>();
    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
