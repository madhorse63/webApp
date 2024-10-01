using HotelManager.DTOs;

namespace HotelManager.Data.Stores.Room
{
    public class RoomStore : IRoomStore
    {
        private static List<RoomDTO> _rooms = new List<RoomDTO>
        {
            new RoomDTO(0, 1, 250, DTOs.Enums.RoomType.Standart),
            new RoomDTO(1, 2, 30, DTOs.Enums.RoomType.Economy),
            new RoomDTO(2, 3, 20, DTOs.Enums.RoomType.Economy),
            new RoomDTO(3, 4, 250, DTOs.Enums.RoomType.Standart),
            new RoomDTO(4, 5, 1000, DTOs.Enums.RoomType.Luxury)
        };

        public List<RoomDTO> Rooms { get { return _rooms; } }

        public List<RoomDTO> GetAllRooms()
        {
            return _rooms;
        }

        public RoomDTO GetRoom(int id)
        {
            return _rooms[id];
        }

        public void CreateRoom(RoomDTO room)
        {
            RoomDTO newRoom = new RoomDTO(room.Id, room.Number, room.Price, room.Type);

            _rooms.Add(newRoom);
        }

        public void UpdateRoom(int id, RoomDTO updateRoom)
        {
            var room = _rooms[id];

            room.Number = updateRoom.Number;
            room.Price = updateRoom.Price;
            room.Type = updateRoom.Type;
        }

        public void RemoveRoom(int id)
        {
            _rooms.RemoveAt(id);
        }
    }
}
