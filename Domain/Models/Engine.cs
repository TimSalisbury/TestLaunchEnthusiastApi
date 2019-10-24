using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace TestAPI.Domain.Models
{
    /// <summary>
    /// Represents an engine database object
    /// </summary>
    public class Engine : DatabaseObject
    {
        [BsonElement("name", Order = 2)]
        public string Name { get; set; }

        [BsonElement("designer", Order = 3)]
        public string Designer { get; set; }

        [BsonElement("manufacturer", Order = 4)]
        public string Manufacturer { get; set; }

        [BsonElement("propellent", Order = 5)]
        public IList<string> Propellents { get; set; }

        [BsonElement("thrust", Order = 6)]
        public Thrust Thrust { get; set; }

        [BsonElement("dimensions", Order = 7)]
        public Dimension Dimension { get; set; }

        [BsonElement("cycle", Order = 8)]
        public string Cycle { get; set; }
        
        [BsonElement("wikipedia", Order = int.MaxValue)]
        public string Wikipedia { get; set; }
    }
}