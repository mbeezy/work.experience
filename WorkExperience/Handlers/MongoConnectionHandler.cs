using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WorkExperience.Models;

namespace WorkExperience.Handlers
{
    public class MongoConnectionHandler<T> where T : IMongoEntity
    {
        public MongoCollection<T> MongoCollection { get; set; }

        public MongoConnectionHandler()
        {
            string connectionString = ConfigurationManager.AppSettings["mongoDbConnectionString"];
            string databaseName = ConfigurationManager.AppSettings["mongoDbName"];

            var mongoClient = new MongoClient(connectionString);
            var mongoServer = mongoClient.GetServer();
            var db = mongoServer.GetDatabase(databaseName);

            MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower());
        }
    }
}