using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Domain.Models;

namespace TestAPI.Domain.Services
{
    public interface IEngineService
    {
        
        /// <summary>
        /// Gets all of the engines
        /// </summary>
        /// <returns>All of the engines</returns>
        List<Engine> Get();

        /// <summary>
        /// Gets an engine specified by the ID
        /// </summary>
        /// <param name="id">The ID of the engine to get</param>
        /// <returns>The engine</returns>
        Engine Get(int id);
    }
}