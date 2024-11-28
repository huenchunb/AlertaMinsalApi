using Microsoft.AspNetCore.Authentication.BearerToken;
using WebApiAlertaMinsal.Application.Common.Interfaces;
using WebApiAlertaMinsal.Domain.Constants;
using WebApiAlertaMinsal.Infrastructure.Data;
using WebApiAlertaMinsal.Infrastructure.Data.Interceptors;
using WebApiAlertaMinsal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Services.SimpleEmailTransferProtocol;
using Microsoft.Extensions.Options;
using WebApiAlertaMinsal.Infrastructure.Services.TemplateRenderer;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        Guard.Against.Null(connectionString, message: "Connection string 'DefaultConnection' not found.");

        services.Configure<SmtpSettings>(configuration.GetSection("SmtpSettings"));
        services.AddSingleton(resolver =>
            resolver.GetRequiredService<IOptions<SmtpSettings>>().Value);

        services.AddScoped<ITemplateRenderer, ScribanTemplateRenderer>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

            options.UseSqlServer(connectionString).UseLazyLoadingProxies();
        });

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<ApplicationDbContextInitialiser>();

        services.AddAuthentication()
            .AddBearerToken(IdentityConstants.BearerScheme);

        services.AddAuthorizationBuilder();

        services
            .AddIdentityCore<ApplicationUser>(options =>
            {
                options.Password.RequiredLength = 7;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddApiEndpoints()
            .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);

        services.AddOptions<BearerTokenOptions>(IdentityConstants.BearerScheme).Configure(options =>
        {
            options.BearerTokenExpiration = TimeSpan.FromDays(1);
        });

        services.AddSingleton(TimeProvider.System);
        services.AddTransient<IIdentityService, IdentityService>();

        services.AddAuthorization(options =>
            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        return services;
    }
}
