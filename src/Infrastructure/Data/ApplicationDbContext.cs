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
    public DbSet<Agresion> Agresion => Set<Agresion>();
    public DbSet<AgresionCategoria> AgresionCategoria => Set<AgresionCategoria>();
    public DbSet<AgresionTestigo> AgresionTestigo => Set<AgresionTestigo>();
    public DbSet<Agresor> Agresor => Set<Agresor>();
    public DbSet<CategoriaAgresion> CategoriaAgresion => Set<CategoriaAgresion>();
    public DbSet<ComplejidadEstablecimiento> ComplejidadEstablecimiento => Set<ComplejidadEstablecimiento>();
    public DbSet<Comuna> Comuna => Set<Comuna>();
    public DbSet<Empleado> Empleado => Set<Empleado>();
    public DbSet<Establecimiento> Establecimiento => Set<Establecimiento>();
    public DbSet<Estamento> Estamento => Set<Estamento>();
    public DbSet<Mutualidad> Mutualidad => Set<Mutualidad>();
    public DbSet<NivelEstablecimiento> NivelEstablecimiento => Set<NivelEstablecimiento>();
    public DbSet<Region> Region => Set<Region>();
    public DbSet<Testigo> Testigo => Set<Testigo>();
    public DbSet<TipoAgresion> TipoAgresion => Set<TipoAgresion>();
    public DbSet<TipoAgresor> TipoAgresor => Set<TipoAgresor>();
    public DbSet<TipoAtencionEstablecimiento> TipoAtencionEstablecimiento => Set<TipoAtencionEstablecimiento>();
    public DbSet<TipoEstablecimiento> TipoEstablecimiento => Set<TipoEstablecimiento>();
    public DbSet<TipoUrgenciaEstablecimiento> TipoUrgenciaEstablecimiento => Set<TipoUrgenciaEstablecimiento>();
    public DbSet<TodoList> TodoList => Set<TodoList>();
    public DbSet<TodoItem> TodoItem => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
