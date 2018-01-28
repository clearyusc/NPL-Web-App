using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Repository
{
    public class EncounterRepository
    {
        private readonly IMongoDatabase _mongoDatabase;
        public EncounterRepository()
        {
            var mongoClient = new MongoClient("mongodb://rcleary:admin@ds117858.mlab.com:17858/simplewebapp-1");
            _mongoDatabase = mongoClient.GetDatabase("simplewebapp-1");
        }

        //Create
        public Encounter AddEncounter(Encounter encounter)
        {
            _mongoDatabase.GetCollection<Encounter>("Encounters").InsertOne(encounter);
            return encounter;
        }

        //Read
        public IEnumerable<Encounter> GetEncounters()
        {
            return _mongoDatabase.GetCollection<Encounter>("Encounters").Find(FilterDefinition<Encounter>.Empty).ToList();
        }

        public Encounter GetEncounterById(int encounterId)
        {
            var filter = Builders<Encounter>.Filter.Eq(e => e.EncounterId, encounterId);
            return _mongoDatabase.GetCollection<Encounter>("Encounters").Find(filter).FirstOrDefault();
        }

        //Update
        public void UpdateEncounter(int encounterId, Encounter encounter)
        {
            var filter = Builders<Encounter>.Filter.Eq(e => e.EncounterId, encounterId);
            var update = Builders<Encounter>.Update
                .Set(x => x.PersonEncountered, encounter.PersonEncountered)
                .Set(x => x.MinistryActions, encounter.MinistryActions)
                .Set(x => x.Notes, encounter.Notes)
                .Set(x => x.MinistryResponse, encounter.MinistryResponse);

            var updateResult = _mongoDatabase.GetCollection<Encounter>("Encounters").UpdateOne(filter, update);

            //Work with updateResult
        }

        //Delete
        public void DeleteEncounter(int encounterId)
        {
            var filter = Builders<Encounter>.Filter.Eq(e => e.EncounterId, encounterId);
            _mongoDatabase.GetCollection<Encounter>("Encounters").DeleteOne(filter);
        }
    }
}
