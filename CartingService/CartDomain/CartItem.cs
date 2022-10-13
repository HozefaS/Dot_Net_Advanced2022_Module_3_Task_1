using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.CartDomain
{
    public record CartItem
    {
        //[BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        //[BsonElement("_id")]
        public string _id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }


    }

}
