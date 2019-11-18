using System.Collections.Generic;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;

namespace TestAPI.Domain.Services
{
    public class LaunchSiteService : ILaunchSiteService
    {

        private readonly ILaunchSiteRepository _launchSiteRepository;

        public LaunchSiteService(ILaunchSiteRepository launchSiteRepository)
        {
            _launchSiteRepository = launchSiteRepository;
        }

        public List<LaunchSite> Get()
        {
            return _launchSiteRepository.Get();
        }

        public LaunchSite Get(int id)
        {
            return _launchSiteRepository.Get(id);
        }
    }
}