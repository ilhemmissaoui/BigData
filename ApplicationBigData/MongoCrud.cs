using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBigData
{
    public class MongoCrud
    {
        public IMongoDatabase db;

        public MongoCrud(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void Insert<T>(string table,T objet )
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(objet);
        }

        public List<T> Affiche<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
