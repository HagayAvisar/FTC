using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCBL
{
   public static class DBHandler
    {
        private static string _connectionString = @"mongodb://localhost:27017";
        private static string DBNAME = "FTC_DB_DEV";
        private static MongoClient _client;

        static DBHandler()
        {
            _client = new MongoClient(_connectionString);
        }
        //public void InsertOne<T, D>( T collection, D doc) where T : IMongoCollection<T> where D : class
        //{
        //    collection.InsertOne(doc);
        //}

        public static void InsertOne(string collectionName , Object doc)
        {
            try
            {
                var db = _client.GetDatabase(DBNAME);
                var collection = db.GetCollection<Object>(collectionName);

                collection.InsertOne(doc);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
