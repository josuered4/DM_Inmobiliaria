using BussinesObjects.Houses.Entities;
using BussinesObjects.Houses.Interfaces.Controllers;
using BussinesObjects.Houses.Interfaces.Ports.CreateHome;
using BussinesObjects.Houses.Interfaces.Presenters;

namespace Controllers.Houses
{
    public class CreateHouseController : ICreateHouseController
    {
        private readonly ICreateHouseInputPort _inputPort;
        private readonly ICreateHousePresenter _presenter;

        public CreateHouseController(ICreateHouseInputPort inputPort, ICreateHousePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<int> CreateHosue(House house)
        {
            await _inputPort.Handle(house);
            return _presenter.HouseId;
        }
    }
}
