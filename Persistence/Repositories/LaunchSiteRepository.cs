using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class LaunchSiteRepository : BaseRepository<LaunchSite>, ILaunchSiteRepository
    {
        public LaunchSiteRepository(AppDbContext context) : base(context, "launchsite")
        {
        }
    }
}