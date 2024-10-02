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
            try
            {
                return Ok(_roomService.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            try
            {
                return Ok(_roomService.Get(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CreateRoom(RoomDTO room)
        {
            try
            {
                _roomService.Create(room);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, RoomDTO room)
        {
            try
            {
                _roomService.Update(id, room);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                _roomService.Remove(id);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
