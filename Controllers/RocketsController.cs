using Microsoft.AspNetCore.Mvc;
using TestAPI.Domain.Repositories;
using TestAPI.Domain.Services;

namespace TestAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RocketsController : ControllerBase
    {
        private readonly IRocketService _rocketService;

        public RocketsController(IRocketService rocketService)
        {
            _rocketService = rocketService;
        }
        
        [HttpGet]
        public IActionResult Get([FromQuery(Name = "id")] int id = -1)
        {
            return id == -1 ? Ok(_rocketService.Get()) : Ok(_rocketService.Get(id));
        }
        
        [HttpGet("{id:int}")]
        public IActionResult GetSingleEngine(int id)
        {
            return Ok(_rocketService.Get(id));
        }
    }
}