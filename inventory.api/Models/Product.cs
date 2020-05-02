using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using inventory.api.Repository;

namespace inventory.api.Models
{
    public class Product : IIdentifable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]// this one makes it possible to keep Id property as string
        [BsonIgnoreIfDefault]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("code")]
        public string Code { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
        
        [BsonElement("unitPrice")]
        public float UnitPrice { get; set; }

        [BsonElement("tags")]
        public string[] Tags { get; set; }
    }
}