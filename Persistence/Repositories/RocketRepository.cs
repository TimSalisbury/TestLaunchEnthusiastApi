using System.Collections.Generic;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Domain.Repositories;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public class RocketRepository : BaseRepository<Rocket>, IRocketRepository
    {
        public RocketRepository(AppDbContext context) : base(context, "rockets")
        {
        }
    }
}