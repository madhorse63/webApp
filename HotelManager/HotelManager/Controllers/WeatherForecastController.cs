using HotelManager.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]       
        
        //public IActionResult Get()
        //{
        //    RoomController roomController = new RoomController();

        //    return Ok(roomController.rooms);
        //}
        public string Get()
        {

            
            
            return "BOO!";


        }
    }
}
