using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkExperience.Handlers;
using WorkExperience.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace WorkExperience.Services
{
    public abstract class EntityService<T> : IEntityService<T> where T : IMongoEntity
    {
        protected readonly MongoConnectionHandler<T> MongoConnectionHandler;

        protected EntityService()
        {
            MongoConnectionHandler = new MongoConnectionHandler<T>();
        }

        public virtual void Create(T entity)
        {
            var result = MongoConnectionHandler.MongoCollection.Save(entity, new MongoInsertOptions { WriteConcern = WriteConcern.Acknowledged });
        }

        public void Delete(string id)
        {
            var result = MongoConnectionHandler.MongoCollection.Remove(Query<T>.EQ(e => e.Id, new ObjectId(id)), RemoveFlags.None, WriteConcern.Acknowledged);
        }

        public T GetById(string id)
        {
            var entityQuery = Query<T>.EQ(e => e.Id, new ObjectId(id));
            return MongoConnectionHandler.MongoCollection.FindOne(entityQuery);
        }

        public void Update(T entity)
        {
        }
    }
}