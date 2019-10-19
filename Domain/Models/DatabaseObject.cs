using System;
using MongoDB.Bson.Serialization.Attributes;

namespace TestAPI.Domain.Models
{
    public abstract class DatabaseObject
    {
        [BsonElement("wikipedia", Order = int.MaxValue)]
        public string Wikipedia { get; set; }
    }
}