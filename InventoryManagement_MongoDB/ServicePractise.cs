using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace InventoryManagement_MongoDB
{
    public class ServicePractise
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Product> _products;

        public ServicePractise()
        {
            var client = new MongoClient("client connection");

            _database = client.GetDatabase("DB name");

            _products = _database.GetCollection<Product>("name of collection");
        }

        public IMongoCollection<Product> GetProductCollection()
        {
            return _products;
        }
    }
}
