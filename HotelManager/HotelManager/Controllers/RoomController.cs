using Microsoft.AspNetCore.Mvc;

using HotelManager.Core.DTOs.RoomDTO;
using HotelManager.Domain.Services.Room;
using HotelManager.Data.Entites.Room;

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
        public async Task<IActionResult> GetAllRooms()
        {
            try
            {
                IEnumerable<RoomDTO> rooms = await _roomService.GetAllAsync();

                return Ok(rooms);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            try
            {
                var room = await _roomService.GetAsync(id);

                return Ok(room);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(Room room)
        {
            try
            {
                await _roomService.CreateAsync(room);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Room room)
        {
            try
            {
                await _roomService.UpdateAsync(id, room);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> Remove(int id)
        {
            try
            {
                await _roomService.RemoveAsync(id);

                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
