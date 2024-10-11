using HotelManager.Data.Stores.RoomStore;
using HotelManager.Core.DTOs.RoomDTO;

namespace HotelManager.Domain.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomStore _roomStore;

        public RoomService(IRoomStore roomStore)
        {
            _roomStore = roomStore;
        }

        public async Task <IEnumerable<RoomDTO>> GetAllAsync()
        {
            try
            {
                var rooms = await _roomStore.GetAllAsync();

                return rooms.Select(room => new RoomDTO(room.Id, room.Number, room.Price, room.Type));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public async Task<RoomDTO> GetAsync(int id)
        {
            var room = await _roomStore.GetAsync(id);
            return new RoomDTO(room.Id, room.Number, room.Price, room.Type);
        }

        public async Task CreateAsync(Data.Entites.Room.Room room)
        {
            await _roomStore.CreateAsync(room);
        }

        public async Task UpdateAsync(int id, Data.Entites.Room.Room room)
        {
            await _roomStore.UpdateAsync(id, room);
        }

        public async Task RemoveAsync(int id)
        {
            await _roomStore.RemoveAsync(id);
        }
    }
}
