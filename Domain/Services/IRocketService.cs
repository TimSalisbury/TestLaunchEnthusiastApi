using System.Collections.Generic;
using TestAPI.Domain.Models;

namespace TestAPI.Domain.Services
{
    public interface IRocketService
    {
                
        /// <summary>
        /// Gets all of the engines
        /// </summary>
        /// <returns>All of the engines</returns>
        List<Rocket> Get();

        /// <summary>
        /// Gets an engine specified by the ID
        /// </summary>
        /// <param name="id">The ID of the engine to get</param>
        /// <returns>The engine</returns>
        Rocket Get(int id);
    }
}