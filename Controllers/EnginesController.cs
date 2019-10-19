using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Domain.Services;

namespace TestAPI.Controllers
{
    /// <summary>
    /// Controls the engines API endpoint
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EnginesController : ControllerBase
    {

        private readonly IEngineService _engineService;

        public EnginesController(IEngineService engineService)
        {
            _engineService = engineService;
        }
        
        /// <summary>
        /// HTTP GET endpoint for either returning the entire engine list
        /// or a specific engine specified by the ID
        /// </summary>
        /// <param name="id">The optional ID of the engine to return</param>
        /// <returns>The entire Engine list or one specified by the ID</returns>
        [HttpGet]
        public IActionResult Get([FromQuery(Name = "id")] int id = -1)
        {
            return id == -1 ? Ok(_engineService.Get()) : Ok(_engineService.Get(id));
        }

        /// <summary>
        /// HTTP GET endpoint for returning an engine by the specified ID
        /// </summary>
        /// <param name="id">The ID of the engine to return</param>
        /// <returns>The engine specified by the ID</returns>
        [HttpGet("{id:int}")]
        public IActionResult GetSingleEngine(int id)
        {
            return Ok(_engineService.Get(id));
        }
    }
}