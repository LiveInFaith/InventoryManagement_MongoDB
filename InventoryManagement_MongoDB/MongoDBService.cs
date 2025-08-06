using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace InventoryManagement_MongoDB
{
    public class MongoDBService
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Product> _products;

        public MongoDBService() {
            var client = new MongoClient("Enter connection string");
        }

    }
}
