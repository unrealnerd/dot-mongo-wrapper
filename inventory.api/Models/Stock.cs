using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using inventory.api.Repository;

namespace inventory.api.Models
{
    public class Stock : IIdentifable
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]// this one makes it possible to keep Id property as string
        [BsonIgnoreIfDefault]
        public string Id { get; set; }

        [BsonElement("product_id")]
        public string ProductId { get; set; }

        [BsonElement("total_quantity")]
        public int TotalQuantity { get; set; }

        [BsonElement("sold_quantity")]
        public int SoldQuantity { get; set; }

        [BsonElement("damaged_quantity")]
        public int DamagedQuantity { get; set; }
        
        [BsonElement("tags")]
        public string[] Tags { get; set; }
    }
}