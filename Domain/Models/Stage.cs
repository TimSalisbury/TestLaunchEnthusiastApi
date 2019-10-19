using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Stage
    {

        [BsonElement("number_engines")]
        public int NumberOfStages { get; set; }

        [BsonElement("engines_id")]
        public int EnginesID { get; set; }

        [BsonElement("engines_name")]
        public string EngineName { get; set; }

        [BsonElement("dimensions")]
        public Dimension Dimension { get; set; }

        [BsonElement("thrust")]
        public Thrust Thrust;

        [BsonElement("isp")]
        public string ISP { get; set; }
    }
}