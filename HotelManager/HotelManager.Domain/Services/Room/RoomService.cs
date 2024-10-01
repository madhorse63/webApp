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

        public List<RoomDTO> GetAllRooms()
        {
            return _roomStore.GetAllRooms();
        }

        public RoomDTO GetRoom(int id)
        {
            return _roomStore.GetRoom(id);
        }

        public void CreateRoom(RoomDTO room)
        {
            _roomStore.CreateRoom(room);
        }

        public void UpdateRoom(int id, RoomDTO room)
        {
            _roomStore.UpdateRoom(id, room);
        }

        public void RemoveRoom(int id)
        {
            _roomStore.RemoveRoom(id);
        }
    }
}
