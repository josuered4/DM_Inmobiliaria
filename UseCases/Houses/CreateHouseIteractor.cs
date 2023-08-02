using BussinesObjects.Houses.Entities;
using BussinesObjects.Houses.Interfaces.Ports.CreateHome;
using BussinesObjects.Houses.Interfaces.Repositories;

namespace UseCases.Houses
{
    public class CreateHouseIteractor : ICreateHouseInputPort
    {
        private readonly ICreateHouseOutputPort _outputPort;
        private readonly IHouseCommandsRepository _repository;

        public CreateHouseIteractor(ICreateHouseOutputPort outputPort, IHouseCommandsRepository repository)
        {
            _outputPort = outputPort;
            _repository = repository;
        }

        public async ValueTask Handle(House house)
        {
            await _repository.CreateHosue(house);
            await _repository.SaveChanges();
            await _outputPort.Handler(house.Id);
        }
    }
}
