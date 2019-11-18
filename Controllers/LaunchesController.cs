using Microsoft.AspNetCore.Mvc;
using TestAPI.Domain.Services;

namespace TestAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LaunchesController : ControllerBase
    {
        private readonly ILaunchService _launchService;

        public LaunchesController(ILaunchService launchService)
        {
            _launchService = launchService;
        }
        
        [HttpGet]
        public IActionResult Get([FromQuery(Name = "id")] int id = -1)
        {
            if (id == -1) return Ok(_launchService.Get());
            var engine = _launchService.Get(id);
            if (engine == null) return NotFound();
            return Ok(engine);
        }

        /// <summary>
        /// HTTP GET endpoint for returning an engine by the specified ID
        /// </summary>
        /// <param name="id">The ID of the engine to return</param>
        /// <returns>The engine specified by the ID</returns>
        [HttpGet("{id:int}")]
        public IActionResult GetSingleEngine(int id)
        {
            var engine = _launchService.Get(id);
            if (engine == null) return NotFound();
            return Ok(engine);
        }
    }
}