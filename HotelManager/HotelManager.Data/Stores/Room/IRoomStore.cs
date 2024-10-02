using HotelManager.DTOs;

namespace HotelManager.Data.Stores.Room
{
    public interface IRoomStore
    {
        public List<RoomDTO> GetAll();

        public RoomDTO Get(int id);

        public void Create(RoomDTO room);

        public void Update(int id, RoomDTO room);

        public void Remove(int id);
    }
}
