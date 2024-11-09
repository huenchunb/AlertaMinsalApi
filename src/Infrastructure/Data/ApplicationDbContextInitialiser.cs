using WebApiAlertaMinsal.Domain.Constants;
using WebApiAlertaMinsal.Domain.Entities;
using WebApiAlertaMinsal.Infrastructure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApiAlertaMinsal.Infrastructure.Data;

public static class InitialiserExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();

        await initialiser.InitialiseAsync();

        await initialiser.SeedAsync();
    }
}

public class ApplicationDbContextInitialiser(
    ILogger<ApplicationDbContextInitialiser> logger,
    ApplicationDbContext context,
    UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager)
{
    public async Task InitialiseAsync()
    {
        try
        {
            await context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    private async Task TrySeedAsync()
    {
        // Default roles
        var administratorRole = new IdentityRole(Roles.Administrator);

        if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await roleManager.CreateAsync(administratorRole);
        }

        // Default users
        var administrator =
            new ApplicationUser { UserName = "administrator@localhost.com", Email = "administrator@localhost.com" };

        if (userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await userManager.CreateAsync(administrator, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(administratorRole.Name))
            {
                await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }

        // Default data
        // Seed, if necessary
        if (!context.TodoLists.Any())
        {
            context.TodoLists.Add(new TodoList
            {
                Title = "Todo List",
                Items =
                {
                    new TodoItem { Title = "Make a todo list 📃" },
                    new TodoItem { Title = "Check off the first item ✅" },
                    new TodoItem { Title = "Realise you've already done two things on the list! 🤯" },
                    new TodoItem { Title = "Reward yourself with a nice, long nap 🏆" },
                }
            });

            await context.SaveChangesAsync();
        }

        if (!context.Niveles.Any())
        {
            await context.Niveles.AddRangeAsync(new List<NivelEstablecimiento>
            {
                new("Primario"), new("Secundario"), new("Terciario")
            });

            await context.SaveChangesAsync();
        }

        if (!context.Complejidades.Any())
        {
            await context.Complejidades.AddRangeAsync(new List<ComplejidadEstablecimiento>
            {
                new("Baja complejidad"), new("Mediana complejidad"), new("Alta complejidad")
            });

            await context.SaveChangesAsync();
        }

        if (!context.TiposAtenciones.Any())
        {
            await context.TiposAtenciones.AddRangeAsync(new List<TipoAtencionEstablecimiento>
            {
                new("Atención abierta-ambulatoria"), new("Atención cerrada-hospitalaria")
            });

            await context.SaveChangesAsync();
        }

        if (!context.TiposEstablecimientos.Any())
        {
            await context.TiposEstablecimientos.AddRangeAsync(new List<TipoEstablecimiento>
            {
                new("Servicio de atención primaria de urgencia (SAPU)"),
                new("Centro de salud familiar (CESFAM)"),
                new("Centro comunitario de salud familiar (CECOSF)"),
                new("Centro comunatario de salud mental (COSAM)"),
                new("Centro de especialidad"),
                new("Dirección servicio de salud"),
                new("Hospital"),
                new("Programa de reparación y atención integral de salud (PRAIS)"),
                new("Unidad de salud funcionarios")
            });

            await context.SaveChangesAsync();
        }

        if (!context.TiposUrgencias.Any())
        {
            await context.TiposUrgencias.AddRangeAsync(new List<TipoUrgenciaEstablecimiento>
            {
                new("No aplica"),
                new("Urgencia hospitalaria (UEH)"),
                new("Hospitalaria especializada"),
                new("Urgencia ambulatoria (SAPU)")
            });

            await context.SaveChangesAsync();
        }
    }
}
