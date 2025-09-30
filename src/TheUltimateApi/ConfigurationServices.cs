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
            .SwaggerDocument(o =>
            {
                o.DocumentSettings = s =>
                {
                    s.DocumentName = "Initial Release";
                    s.Title = "The Ultimate API";
                    s.Version = "v0";
                };
            })
           .SwaggerDocument(o =>
           {
               o.MaxEndpointVersion = 1;
               o.DocumentSettings = s =>
               {
                   s.DocumentName = "Release 1";
                   s.Title = "The New Ultimate API";
                   s.Version = "v1";
               };
           });

        return services;
    }
}
