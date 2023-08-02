using BussinesObjects.Houses.Entities;

namespace BussinesObjects.Houses.Interfaces.Controllers
{
    public interface ICreateHouseController
    {
        ValueTask<int> CreateHosue(House house);
    }
}
