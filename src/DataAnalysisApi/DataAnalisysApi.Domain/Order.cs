using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAnalisysApi.Domain
{
    [BsonIgnoreExtraElements]
    public class Order
    {
        public Order()
        {

        }

        private Guid id { get; set; }

        public DateTime saleDate { get; set; }

        public OrderItem[] items { get; set; }

        public string storeLocation { get; set; }

        public Customer customer { get; set; }

        public bool couponUsed { get; set; }

        public string purchaseMethod { get; set; }
    }
}
