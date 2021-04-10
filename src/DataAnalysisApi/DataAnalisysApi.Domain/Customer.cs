using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAnalisysApi.Domain
{
    public class Customer
    {
        [BsonElement("gender")]
        public string gender { get; set; }

        [BsonElement("age")]
        public int age { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("satisfaction")]
        public int satisfaction { get; set; }
    }
}
