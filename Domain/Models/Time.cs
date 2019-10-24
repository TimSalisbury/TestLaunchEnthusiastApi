using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Time
    {
        [BsonElement("hour", Order = 1)]
        public int Hour { get; set; }
        
        [BsonElement("minute", Order = 2)]
        public int Minute { get; set; }

        [BsonElement("time_zone", Order = 3)]
        public string Timezone { get; set; }
    }
}