using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Rocket
    {
        [BsonId(Order =  1)]
        public int Id { get; set; }

        [BsonElement("designer", Order = 2)]
        public string Designer { get; set; }

        [BsonElement("manufacturer", Order = 3)]
        public string Manufacturer { get; set; }
    }
}