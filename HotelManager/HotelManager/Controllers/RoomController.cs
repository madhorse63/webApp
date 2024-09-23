using HotelManager.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        public List<RoomDTO> rooms = new List<RoomDTO>
        {
            new RoomDTO(0, 1, 250, DTOs.Enums.RoomType.Standart),
            new RoomDTO(1, 2, 30, DTOs.Enums.RoomType.Economy),
            new RoomDTO(2, 3, 20, DTOs.Enums.RoomType.Economy),
            new RoomDTO(3, 4, 250, DTOs.Enums.RoomType.Standart),
            new RoomDTO(4, 5, 1000, DTOs.Enums.RoomType.Luxury)
        };


        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok(rooms[id]);
        }

        [HttpPost]
        public IActionResult CreateRoom(RoomDTO room)
        {
            RoomDTO newRoom = new RoomDTO(room.Id, room.Number, room.Price, room.Type);

            rooms.Add(newRoom);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveRoom(int id)
        {
            rooms.RemoveAt(id);

            return NoContent();
        }
    }
}
