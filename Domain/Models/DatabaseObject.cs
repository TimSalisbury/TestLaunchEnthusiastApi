using System;
using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public abstract class DatabaseObject
    {
        [BsonElement("_id", Order = 0)] 
        public int Id { get; set; }
    }
}