using Microsoft.Extensions.DependencyInjection;

namespace Domain;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureDomain(this IServiceCollection services)
    {
        return services;
    }
}
