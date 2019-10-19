using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using TestAPI.Domain.Models;

namespace TestAPI.Persistence.Contexts
{
    public class AppDbContext
    {
        public IMongoCollection<Engine> Engines { get; set; }
        public IMongoCollection<Rocket> Rockets { get; set; }

        private IMongoDatabase _database { get; }

        public AppDbContext(ITestDatabaseSettings settings)
        {
            var mongoClient = new MongoClient(settings.ConnectionString);
            _database = mongoClient.GetDatabase(settings.DatabaseName);

            Engines = _database.GetCollection<Engine>(settings.EnginesCollectionName);
            Rockets = _database.GetCollection<Rocket>(settings.RocketsCollectionName);
        }
    }
}