using HotelManager.Data.Entites.Room;
using HotelManager.Core.DTOs.RoomDTO;

namespace HotelManager.Domain.Services.Room
{
    public interface IRoomService
    {
        public Task<IEnumerable<RoomDTO>> GetAllAsync();

        public Task<RoomDTO> GetAsync(int id);

        public Task CreateAsync(Data.Entites.Room.Room room);

        public Task UpdateAsync(int id, Data.Entites.Room.Room room);

        public Task RemoveAsync(int id);
    }
}
