using Application.Interfaces;
using FastEndpoints;
using FastEndpoints.Swagger;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TheUltimateApi;

public static class ConfigurationServices
{
    public static IServiceCollection ConfigurePresentation(this IServiceCollection services)
    {
        services
            // database setup
            .AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("MyAppDb"))
            .AddScoped<IUserRepository, UserRepository>()

            // configure FastEndpoints
            .AddFastEndpoints()

            // configure Swagger for FastEndpoints
            .SwaggerDocument();

        return services;
    }
}
