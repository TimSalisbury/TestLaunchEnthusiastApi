using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Launch : DatabaseObject
    {
        [BsonElement("name", Order = 2)] 
        public string Name { get; set; }

        [BsonElement("date", Order = 3)] 
        public Date Date { get; set; }

        [BsonElement("rocket_id", Order = 4)] 
        public int RocketID { get; set; }

        [BsonElement("rocket_name", Order = 5)]
        public string RocketName { get; set; }

        [BsonElement("launch_site", Order = 6)]
        public string LaunchSite { get; set; }

        [BsonElement("launch_success", Order = 7)]
        public bool LaunchSuccess { get; set; }

        [BsonElement("operator", Order = 8)]
        public string Operator { get; set; }

        [BsonElement("flight_number", Order = 9)]
        public int FlightNumber { get; set; }

        [BsonElement("upcoming", Order = 10)]
        public bool Upcoming { get; set; }

        [BsonElement("launch_time", Order = 11)]
        public Time Time { get; set; }

        [BsonElement("link", Order = 12)]
        public string Link { get; set; }

        [BsonElement("press_kit", Order = 13)]
        public string PressKit { get; set; }
    }
}