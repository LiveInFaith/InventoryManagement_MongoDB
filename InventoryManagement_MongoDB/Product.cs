using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InventoryManagement_MongoDB
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Quantity { get; set; }

        public string Price { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} \n Name : {Name} \n Category : {Category} \n Quantity : {Quantity} \n Price : R{Price:F2}";
        }

    }
}
