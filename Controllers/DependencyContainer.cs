using BussinesObjects.Houses.Interfaces.Controllers;
using Controllers.Houses;
using Microsoft.Extensions.DependencyInjection;

namespace Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServiceControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateHouseController, CreateHouseController>();
            return services;
        }
    }
}
