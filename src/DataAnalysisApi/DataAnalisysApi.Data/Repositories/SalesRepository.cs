using DataAnalisysApi.Abstract.Interfaces;
using DataAnalisysApi.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalisysApi.Data.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private IMongoClient _mongoClient;

        public SalesRepository()
        {
            _mongoClient = new MongoClient($"mongodb+srv://fabrilsson:ld0awvdNh0u9ZOPdkf3e1A%3D%3D@cluster0" +
                $"-ue3tn.azure.mongodb.net/sample_suplies?retryWrites=true&w=majority");
        }

        public async Task<List<string>> GetMongoCollections()
        {
            return await _mongoClient.ListDatabaseNames().ToListAsync();
        }

        public async Task<List<Order>> GetOrdersAsync(int top = 1)
        {
            var aaa = _mongoClient.GetDatabase("sample_suplies");

            var bbb = aaa.GetCollection<BsonDocument>("sales");

            var filter = Builders<BsonDocument>.Filter.Empty;

            var ccc = await bbb.FindAsync(filter);

            var aefes = ccc.FirstOrDefaultAsync();

            return null;
        }
    }
}
