using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAnalisysApi.Domain
{
    public class OrderItem
    {
        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("tags")]
        public string[] tags { get; set; }

        [BsonElement("price")]
        public double price { get; set; }

        [BsonElement("quantity")]
        public int quantity { get; set; }
    }
}
