using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public class Stage
    {

        [BsonElement("number_engines", Order = 1)]
        public int NumberOfEngines { get; set; }

        [BsonElement("engines_id", Order = 2)]
        public int EnginesID { get; set; }

        [BsonElement("engines_name", Order = 3)]
        public string EngineName { get; set; }

        [BsonElement("dimensions", Order = 4)]
        public Dimension Dimension { get; set; }

        [BsonElement("thrust", Order = 5)]
        public Thrust Thrust;

        [BsonElement("isp", Order = 6)]
        public string ISP { get; set; }
    }
}