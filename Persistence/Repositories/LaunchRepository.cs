using System.Collections.Generic;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class LaunchRepository : BaseRepository<Launch>, ILaunchRepository
    {
        public LaunchRepository(AppDbContext context) : base(context, "launches")
        {
        }
    }
}