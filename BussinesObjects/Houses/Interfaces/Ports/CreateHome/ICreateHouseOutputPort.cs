namespace BussinesObjects.Houses.Interfaces.Ports.CreateHome
{
    public interface ICreateHouseOutputPort
    {
        ValueTask Handler(int HomeId);
    }
}
