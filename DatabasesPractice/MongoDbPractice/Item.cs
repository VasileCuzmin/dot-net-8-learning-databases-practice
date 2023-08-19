using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
namespace MongoDbPractice
{
    public class Item
    {
        // attribute used to derermine MongoDB driver to generate the IDs for this collection
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))] 
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}

