using Application.Features.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigurationServices
{
    public static IServiceCollection ConfigureApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserHandler, UserHandler>();

        return services;
    }
}
