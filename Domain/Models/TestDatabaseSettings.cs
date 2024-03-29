namespace TestAPI.Domain.Models
{
    public class TestDatabaseSettings : ITestDatabaseSettings
    {
        public string EnginesCollectionName { get; set; }
        public string RocketsCollectionName { get; set; }
        
        public string LaunchesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        
    }

    public interface ITestDatabaseSettings
    {
        string EnginesCollectionName { get; set; }

        string RocketsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string LaunchesCollectionName { get; set; }
    }
}