using HotelManager.DTOs;

namespace HotelManager.Data.Stores.Room
{
    public interface IRoomStore
    {
        public List<RoomDTO> GetAllRooms();

        public RoomDTO GetRoom(int id);

        public void CreateRoom(RoomDTO room);

        public void UpdateRoom(int id, RoomDTO room);

        public void RemoveRoom(int id);
    }
}
