using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace TestAPI.Domain.Models
{
    public class Rocket
    {
        [BsonId(Order =  1)]
        public int Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("designer", Order = 2)]
        public string Designer { get; set; }

        [BsonElement("manufacturer", Order = 3)]
        public string Manufacturer { get; set; }

        [BsonElement("reuseable", Order = 4)]
        public bool Reuseable { get; set; }

        [BsonElement("cost_new")]
        public double CostNew { get; set; }

        [BsonElement("cost_used")]
        public double CostUsed { get; set; }

        [BsonElement("currency")]
        public string Currency { get; set; }

        [BsonElement("launches", Order = 5)]
        [BsonDictionaryOptions(DictionaryRepresentation.Document)]
        public Dictionary<string, double> Launches;

        [BsonElement("first_flight")]
        public string FirstFlight;

        [BsonElement("dimensions")]
        public Dimension Dimensions;

        [BsonElement("launch_sites")]
        public IList<string> LaunchSites;

        [BsonElement("stages")]
        public Dictionary<string, Stage> Stages;
        
        [BsonElement("payload")]
        public Payload Payload;

    }
}