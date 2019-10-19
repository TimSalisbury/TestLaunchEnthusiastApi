using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TestAPI.Domain.Models
{
    public class Dimension
    {
        [BsonElement("diameter", Order = 1)]
        public double Diameter { get; set; }

        [BsonElement("length", Order = 2)] 
        public double Length { get; set; }

        [BsonElement("mass", Order = 3)]
        public double Mass { get; set; }

        [BsonElement("diameter_unit", Order = 4)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement DiameterUnit { get; set; }
        
        [BsonElement("mass_unit", Order = 5)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement MassUnit { get; set; }
    }
}