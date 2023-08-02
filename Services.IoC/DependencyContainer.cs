using Controllers;
using EFCore.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presenters;
using UseCases;

namespace Services.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesCollection(
            this IServiceCollection services,
            IConfiguration configuration,
            string connectionString
        )
        {
            services.AddServiceRepository(configuration, connectionString);
            services.AddServicesUseCases();
            services.AddServicePresenters();
            services.AddServiceControllers();
            return services;
        }
    }
}