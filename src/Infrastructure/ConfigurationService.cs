using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigurationService
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
