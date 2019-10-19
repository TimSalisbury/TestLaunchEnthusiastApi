using System.Collections.Generic;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class RocketRepository : BaseRepository, IRocketRepository
    {
        public RocketRepository(AppDbContext context) : base(context)
        {
            
        }

        public List<Rocket> Get()
        {
            return _context.Rockets.Find(rocket => true).ToList();
        }

        public Rocket Get(int id)
        {
            return _context.Rockets.Find(rocket => rocket.Id == id).FirstOrDefault();
        }
    }
}