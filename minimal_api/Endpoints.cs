using BussinesObjects.Houses.Entities;
using BussinesObjects.Houses.Interfaces.Controllers;

namespace minimal_api
{
    public static class Endpoints
    {
        public static WebApplication UseNorthWindSalesEndpoints(
            this WebApplication app)
        {
            app.MapPost("/create",
                async (House house,
                ICreateHouseController controller) =>
                Results.Ok(await controller.CreateHosue(house)));

            return app;
        }
    }
}
