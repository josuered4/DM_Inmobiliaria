using BussinesObjects.Houses.Interfaces.Presenters;

namespace Presenters.Houses
{
    public class CreateHousePresenter : ICreateHousePresenter
    {
        public int HouseId { get; private set; }

        public ValueTask Handler(int HomeId)
        {
            HouseId = HomeId;
            return ValueTask.CompletedTask;
        }
    }
}
