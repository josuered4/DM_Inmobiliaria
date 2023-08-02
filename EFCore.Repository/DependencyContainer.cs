using BussinesObjects.Houses.Interfaces.Repositories;
using EFCore.Repository.DBContexts;
using EFCore.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServiceRepository(
                this IServiceCollection services,
                IConfiguration configuration,
                string connectionString
        )
        {
            services.AddDbContext<ApplicationBbContext>(
                opt => opt.UseSqlServer(configuration.GetConnectionString(connectionString))
                );

            services.AddScoped<IHouseCommandsRepository, HouseCommandsRepository>();

            return services;
        }
    }
}
