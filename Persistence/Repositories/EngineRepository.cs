using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class EngineRepository : BaseRepository, IEngineRepository
    {
        public EngineRepository(AppDbContext context) : base(context)
        {
            
        }

        public List<Engine> Get()
        {
            return _context.Engines.Find(engine => true).ToList();
        }

        public Engine Get(int id)
        {
            return _context.Engines.Find(engine => engine.Id == id).FirstOrDefault();
        }
    }
}