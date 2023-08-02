using BussinesObjects.Houses.Interfaces.Ports.CreateHome;
using BussinesObjects.Houses.Interfaces.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Presenters.Houses;

namespace Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicePresenters(this IServiceCollection services)
        {
            services.AddScoped<CreateHousePresenter>();
            services.AddScoped<ICreateHouseOutputPort>(
               provider => provider.GetService<CreateHousePresenter>());

            services.AddScoped<ICreateHousePresenter>(
                provider => provider.GetService<CreateHousePresenter>());
            return services;
        }
    }
}
