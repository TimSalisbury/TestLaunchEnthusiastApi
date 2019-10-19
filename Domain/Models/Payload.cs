using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestAPI.Domain.Models
{
    public class Payload
    {
        [BsonElement("LEO")]
        public double LEO { get; set; }

        [BsonElement("GTO")]
        public double GTO { get; set; }

        [BsonElement("Mars")]
        public double Mars { get; set; }

        [BsonElement("unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement PayloadUnit { get; set; }
    }
}