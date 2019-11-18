using System.Collections.Generic;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;

namespace TestAPI.Domain.Services
{
    public class LaunchService : ILaunchService
    {
        private readonly ILaunchRepository _launchRepository;

        public LaunchService(ILaunchRepository launchRepository)
        {
            _launchRepository = launchRepository;
        }

        public List<Launch> Get()
        {
            return _launchRepository.Get();
        }

        public Launch Get(int id)
        {
            return _launchRepository.Get(id);
        }
    }
}