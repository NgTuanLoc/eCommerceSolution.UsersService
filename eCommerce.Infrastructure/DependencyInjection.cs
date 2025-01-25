using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // TODO: Add services to the IoC container
        // Infrastructure services often include data access, caching and other low-level components
        return services;
    }
}
