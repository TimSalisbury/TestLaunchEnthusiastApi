using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using TestAPI.Domain.Models;

namespace TestAPI.Persistence.Contexts
{
    public class AppDbContext
    {
        public IMongoCollection<Engine> Engines { get; set; }
        public static string ConnectionString { get; set; }

        public static string DatabaseName { get; set; }

        private IMongoDatabase _database { get; }

        public AppDbContext(ITestDatabaseSettings settings)
        {
            BsonClassMap.RegisterClassMap<Engine>(e =>
            {
                e.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Dimension>(d => { d.AutoMap(); });

            BsonClassMap.RegisterClassMap<Thrust>(t => { t.AutoMap(); });
            
            
            var mongoClient = new MongoClient(settings.ConnectionString);
            _database = mongoClient.GetDatabase(settings.DatabaseName);

            Engines = _database.GetCollection<Engine>(settings.EnginesCollectionName);
        }
    }
}