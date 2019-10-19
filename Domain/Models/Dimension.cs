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

        [BsonElement("height", Order = 2)] 
        public double Height { get; set; }

        [BsonElement("mass", Order = 3)]
        public double Mass { get; set; }

        [BsonElement("length_unit", Order = 4)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement LengthUnit { get; set; }
        
        [BsonElement("mass_unit", Order = 5)]
        [JsonConverter(typeof(StringEnumConverter))]
        [BsonRepresentation(BsonType.String)]
        public EUnitOfMeasurement MassUnit { get; set; }
    }
}