using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.CartDomain
{
    public class Cart
    {
        [BsonRepresentation(BsonType.ObjectId)]
        //[BsonElement("_id")]
        public string Id { get; set; }

        [BsonElement("items")]
        public List<CartItem> Items { get; set; }

    }

}
