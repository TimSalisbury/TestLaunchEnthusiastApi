using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class EngineRepository : BaseRepository<Engine>, IEngineRepository
    {
        public EngineRepository(AppDbContext context) : base(context, "engines")
        {
            
        }
    }
}