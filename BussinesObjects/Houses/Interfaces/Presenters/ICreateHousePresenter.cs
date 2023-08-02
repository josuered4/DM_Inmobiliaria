using BussinesObjects.Houses.Interfaces.Ports.CreateHome;

namespace BussinesObjects.Houses.Interfaces.Presenters
{
    public interface ICreateHousePresenter : ICreateHouseOutputPort
    {
        int HouseId { get; }
    }
}
