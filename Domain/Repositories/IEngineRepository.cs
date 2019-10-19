using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Domain.Models;

namespace TestAPI.Domain.Repositories
{
    public interface IEngineRepository
    {
        List<Engine> Get();

        Engine Get(int id);
    }
}