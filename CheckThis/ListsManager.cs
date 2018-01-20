using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class ListsManager
    {
        private readonly IMongoClient _mongoProvider;

        public ListsManager(IMongoClient mongoProvider)
        {
            _mongoProvider = mongoProvider;
        }
    
        //TODO - remove once app in place with injection
        public ListsManager()
        {
            _mongoProvider = new MongoClient("mongodb+srv://gymbratjodee:checkthisservice@cluster0-p0lw4.mongodb.net/test");
        }

        public long CountListsTest()
        {
            var database = _mongoProvider.GetDatabase("CheckThis");
            var collection = database.GetCollection<BsonDocument>("Lists");
            var count = collection.Count(new BsonDocument());
            return count;
        }
    }

    public interface IListManager
    {

    }

}
