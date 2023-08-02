using BussinesObjects.Houses.Entities;
using BussinesObjects.Houses.Interfaces.Repositories;
using EFCore.Repository.DBContexts;

namespace EFCore.Repository.Repositories
{
    public class HouseCommandsRepository : IHouseCommandsRepository
    {
        private readonly ApplicationBbContext _context;
        public HouseCommandsRepository(ApplicationBbContext context)
        {
            _context = context;
        }
        public async ValueTask CreateHosue(House house)
        {
            await _context.Houses.AddAsync(house);
        }

        public ValueTask DeleteHosue(House house)
        {
            _context.Remove(house);
            return ValueTask.CompletedTask;
        }

        public async ValueTask SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public ValueTask UpdateHosue(House house)
        {
            _context.Update(house);
            return ValueTask.CompletedTask;
        }
    }
}
