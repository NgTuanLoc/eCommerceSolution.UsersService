﻿using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Add services to the IoC container
        // Infrastructure services often include data access, caching and other low-level components
        services.AddTransient<IUserRepository, UsersRepository>();
        services.AddTransient<DapperDbContext>();

        return services;
    }
}
