using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using SimpleWebApp.Repository;

namespace SimpleWebApp.Repository
{
    public enum MinistryAction { Prayer, Testimony, Gospel };
    public enum MinistryResponse { Undefined, RedLight, YellowLight, GreenLight, BelieverWantsTraining, BelieverDoesNotWantTraining };
    public class Encounter
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("EncounterId")]
        public int EncounterId { get; set; }

        [BsonElement("PersonEncountered")]
        public Person PersonEncountered { get; set; }

        [BsonElement("Response")]
        public MinistryResponse MinistryResponse { get; set; } = MinistryResponse.Undefined;

        [BsonElement("Notes")]
        public string Notes { get; set; }

        [BsonElement("Timestamp")]
        public DateTime Timestamp { get; set; }

        [BsonElement("MinistryActions")]
        public List<MinistryAction> MinistryActions { get; set; }


        public Encounter()
        {
            PersonEncountered = new Person();
            MinistryActions = new List<MinistryAction>();
        }
    }
}