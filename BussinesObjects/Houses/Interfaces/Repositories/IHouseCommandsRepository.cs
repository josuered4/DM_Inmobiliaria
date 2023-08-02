using BussinesObjects.Houses.Entities;
using Entities.Interfaces;

namespace BussinesObjects.Houses.Interfaces.Repositories
{
    public interface IHouseCommandsRepository : IUnitOfWork
    {
        ValueTask CreateHosue(House house);
        ValueTask UpdateHosue(House house);
        ValueTask DeleteHosue(House house);
    }
}
