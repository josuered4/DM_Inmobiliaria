using Entities.Entities;

namespace BussinesObjects.Houses.Entities
{
    public class House : Properties
    {
        public int Levels { get; set; }
        public bool LivingRoom { get; set; }
        public int Bathrooms { get; set; }
        public bool Garden { get; set; }
        public int Bedrooms { get; set; }
        public bool Kitchen { get; set; }
        public bool ServiceYard { get; set; }
        public int ParkingLot { get; set; }

    }
}
