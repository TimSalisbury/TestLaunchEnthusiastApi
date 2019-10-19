using System.Collections.Generic;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;

namespace TestAPI.Domain.Services
{
    public class RocketService : IRocketService
    {
        private readonly IRocketRepository _rocketRepository;

        public RocketService(IRocketRepository rocketRepository)
        {
            _rocketRepository = rocketRepository;
        }

        public List<Rocket> Get()
        {
            return _rocketRepository.Get();
        }

        public Rocket Get(int id)
        {
            return _rocketRepository.Get(id);
        }
    }
}