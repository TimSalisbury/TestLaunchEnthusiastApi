using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestAPI.Domain.Models
{
    public class Payload
    {
        [BsonElement("LEO", Order = 1)]
        public double LEO { get; set; }

        [BsonElement("GTO", Order = 2)]
        public double GTO { get; set; }

        [BsonElement("Mars", Order = 3)]
        public double Mars { get; set; }

        [BsonElement("unit", Order = 4)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement PayloadUnit { get; set; }
    }
}