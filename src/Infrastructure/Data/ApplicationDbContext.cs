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
    public DbSet<Agresion> Agresiones => Set<Agresion>();
    public DbSet<AgresionCategoria> AgresionesCategorias => Set<AgresionCategoria>();
    public DbSet<AgresionTestigo> AgresionesTestigos => Set<AgresionTestigo>();
    public DbSet<Agresor> Agresores => Set<Agresor>();
    public DbSet<CategoriaAgresion> TipoAgresionCategorias => Set<CategoriaAgresion>();
    public DbSet<ComplejidadEstablecimiento> Complejidades => Set<ComplejidadEstablecimiento>();
    public DbSet<Comuna> Comunas => Set<Comuna>();
    public DbSet<Empleado> Empleados => Set<Empleado>();
    public DbSet<Establecimiento> Establecimientos => Set<Establecimiento>();
    public DbSet<Estamento> Estamentos => Set<Estamento>();
    public DbSet<Mutualidad> Mutualidades => Set<Mutualidad>();
    public DbSet<NivelEstablecimiento> Niveles => Set<NivelEstablecimiento>();
    public DbSet<Region> Regiones => Set<Region>();
    public DbSet<Testigo> Testigos => Set<Testigo>();
    public DbSet<TipoAgresion> TiposAgresiones => Set<TipoAgresion>();
    public DbSet<TipoAgresor> TiposAgresores => Set<TipoAgresor>();
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
