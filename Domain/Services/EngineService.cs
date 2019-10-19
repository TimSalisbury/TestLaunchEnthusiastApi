using System.Collections.Generic;
using System.Threading.Tasks;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;

namespace TestAPI.Domain.Services
{
    public class EngineService : IEngineService
    {

        private readonly IEngineRepository _engineRepository;

        public EngineService(IEngineRepository engineRepository)
        {
            _engineRepository = engineRepository;
        }

        public List<Engine> Get()
        {
            return _engineRepository.Get();
        }

        public Engine Get(int id)
        {
            return _engineRepository.Get(id);
        }
    }
}