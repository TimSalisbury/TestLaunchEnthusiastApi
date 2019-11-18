using System.Collections.Generic;
using MongoDB.Driver;
using TestAPI.Domain.Models;
using TestAPI.Persistence.Contexts;

namespace TestAPI.Persistence.Repositories
{
    public abstract class BaseRepository<T> where T: DatabaseObject
    {
        protected readonly AppDbContext _context;

        private readonly IMongoCollection<T> Collection;

        protected BaseRepository(AppDbContext context, string CollectionName)
        {
            _context = context;
            Collection = _context.GetCollection<T>(CollectionName);
        }
        
        public List<T> Get()
        {
            return Collection.Find(type => true).ToList();
        }

        public T Get(int id)
        {
            return Collection.Find(type => type.Id == id).FirstOrDefault();
        }
        
    }
}