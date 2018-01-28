using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SimpleWebApp.Models;
using System;

namespace SimpleWebApp.Repository
{
    public class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("EmployeeId")]
        public int EmployeeId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Position")]
        public string Position { get; set; }

        [BsonElement("JoinedDate")]
        public DateTime JoinedDate { get; set; }

        [BsonElement("Person")]
        public Person Person { get; set; }
    }
}