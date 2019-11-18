using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class LaunchSite : DatabaseObject
    {
        [BsonElement("operator", Order = 1)]
        public string Operator { get; set; }

        [BsonElement("country", Order = 2)]
        public string Country { get; set; }

        [BsonElement("launch_pads", Order = 3)]
        public int LaunchPads { get; set; }

        [BsonElement("first_launch", Order = 4)]
        public Date FirstLaunch { get; set; }

        [BsonElement("coordinates", Order = 5)]
        public string Coordinates { get; set; }

        [BsonElement("total_launches", Order = 6)]
        public int TotalLaunches { get; set; }
    }
}