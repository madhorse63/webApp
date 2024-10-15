using HotelManager.Data.Entites.Room;


namespace HotelManager.Data.Stores.RoomStore
{
    public interface IRoomStore
    {
        Task<IEnumerable<Room>> GetAllAsync();

        Task <Room> GetAsync(int id);

        Task CreateAsync(Room room);

        Task UpdateAsync(int id, Room room);

        Task RemoveAsync(int id);
    }
}
