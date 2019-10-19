using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestAPI.Domain.Models
{
    public class Thrust
    {
        [BsonElement("thrustVac", Order = 1)]
        public double ThrustVacuum { get; set; }

        [BsonElement("thrustSL", Order = 2)]
        public double ThrustSealevel { get; set; }

        [BsonElement("thrust_unit", Order = 3)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement ThrustUnit { get; set; }
    }
}