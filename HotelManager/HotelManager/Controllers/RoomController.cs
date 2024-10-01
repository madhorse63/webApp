using Microsoft.AspNetCore.Mvc;

using HotelManager.DTOs;
using HotelManager.Domain.Services.Room;

namespace HotelManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(_roomService.GetAllRooms());
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok(_roomService.GetRoom(id));
        }

        [HttpPost]
        public IActionResult CreateRoom(RoomDTO room)
        {
            _roomService.CreateRoom(room);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, RoomDTO room)
        {
            _roomService.UpdateRoom(id, room);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveRoom(int id)
        {
            _roomService.RemoveRoom(id);

            return NoContent();
        }
    }
}
