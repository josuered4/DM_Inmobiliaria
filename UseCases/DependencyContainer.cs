using BussinesObjects.Houses.Interfaces.Ports.CreateHome;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Houses;

namespace UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateHouseInputPort, CreateHouseIteractor>();
            return services;
        }
    }
}
