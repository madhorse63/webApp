using HotelManager.Data.Stores.Room;
using HotelManager.DTOs;

namespace HotelManager.Domain.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomStore _roomStore;

        public RoomService(IRoomStore roomStore)
        {
            _roomStore = roomStore;
        }

        public List<RoomDTO> GetAll()
        {
            return _roomStore.GetAll();
        }

        public RoomDTO Get(int id)
        {
            return _roomStore.Get(id);
        }

        public void Create(RoomDTO room)
        {
            _roomStore.Create(room);
        }

        public void Update(int id, RoomDTO room)
        {
            _roomStore.Update(id, room);
        }

        public void Remove(int id)
        {
            _roomStore.Remove(id);
        }
    }
}
