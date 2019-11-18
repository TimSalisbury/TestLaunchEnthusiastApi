using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace TestAPI.Domain.Models
{
    public class Rocket : DatabaseObject
    {
        [BsonElement("name", Order = 2)]
        public string Name { get; set; }

        [BsonElement("designer", Order = 3)]
        public string Designer { get; set; }

        [BsonElement("manufacturer", Order = 4)]
        public string Manufacturer { get; set; }

        [BsonElement("reuseable", Order = 5)]
        public bool Reuseable { get; set; }

        [BsonElement("cost_new", Order = 6)]
        public double CostNew { get; set; }

        [BsonElement("cost_used", Order = 7)]
        public double CostUsed { get; set; }

        [BsonElement("currency", Order = 8)]
        public string Currency { get; set; }

        [BsonElement("launches", Order = 9)]
        [BsonDictionaryOptions(DictionaryRepresentation.Document)]
        public Dictionary<string, double> Launches;

        [BsonElement("first_flight", Order = 10)]
        public string FirstFlight;

        [BsonElement("dimensions", Order = 11)]
        public Dimension Dimensions;

        [BsonElement("launch_sites", Order = 12)]
        public IList<string> LaunchSites;

        [BsonElement("stages", Order = 13)]
        public Dictionary<string, Stage> Stages;
        
        [BsonElement("payload", Order = 14)]
        public Payload Payload;
        
        [BsonElement("wikipedia", Order = int.MaxValue)]
        public string Wikipedia { get; set; }

        [BsonElement("image", Order = 15)] public string Image { get; set; }
    }
}