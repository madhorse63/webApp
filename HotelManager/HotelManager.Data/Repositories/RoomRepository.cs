using HotelManager.Data.Entites.Room;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private HotelManagerDbContext _context { get; }

        public RoomRepository(HotelManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetAsync(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task CreateAsync(Room room)
        {
            Room newRoom = new Room(room.Id, room.Number, room.Price, room.Type);

            await _context.Rooms.AddAsync(newRoom);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Room updatedRoom)
        {
            var room = await _context.Rooms.FindAsync(id);

            room.Number = updatedRoom.Number;
            room.Price = updatedRoom.Price;
            room.Type = updatedRoom.Type;

            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(int id)
        {
            var room = await _context.Rooms.FindAsync(id);

            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}
