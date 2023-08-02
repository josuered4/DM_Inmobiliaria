using BussinesObjects.Houses.Entities;

namespace BussinesObjects.Houses.Interfaces.Ports.CreateHome
{
    public interface ICreateHouseInputPort
    {
        ValueTask Handle(House house);
    }
}
