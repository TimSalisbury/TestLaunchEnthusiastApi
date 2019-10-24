using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Date
    {
        [BsonElement("day", Order = 1)]
        public int Day { get; set; }

        [BsonElement("month", Order = 2)]
        public int Month { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }
    }
}