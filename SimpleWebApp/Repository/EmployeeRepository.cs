using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Repository
{
    public class EmployeeRepository
    {
        private readonly IMongoDatabase _mongoDatabase;
        public EmployeeRepository()
        {
            var mongoClient = new MongoClient("mongodb://rcleary:admin@ds117858.mlab.com:17858/simplewebapp-1");
            _mongoDatabase = mongoClient.GetDatabase("simplewebapp-1");
        }

        //Create
        public Employee AddEmployee(Employee entity)
        {
            _mongoDatabase.GetCollection<Employee>("Employee").InsertOne(entity);
            return entity;
        }

        //Read
        public IEnumerable<Employee> GetEmployees()
        {
            return _mongoDatabase.GetCollection<Employee>("Employee").Find(FilterDefinition<Employee>.Empty).ToList();
        }

        public Employee GetEmployeeById(int empId)
        {
            var filter = Builders<Employee>.Filter.Eq(employee => employee.EmployeeId, empId);
            return _mongoDatabase.GetCollection<Employee>("Employee").Find(filter).FirstOrDefault();
        }

        //Update
        public void UpdateEmployee(int empId, Employee entity)
        {
            var filter = Builders<Employee>.Filter.Eq(employee => employee.EmployeeId, empId);
            var update = Builders<Employee>.Update
                .Set(x => x.Name, entity.Name)
                .Set(x => x.Position, entity.Position)
                .Set(x => x.JoinedDate, entity.JoinedDate);

            var updateResult = _mongoDatabase.GetCollection<Employee>("Employee").UpdateOne(filter, update);

            //Work with updateResult
        }

        //Delete
        public void DeleteEmployee(int empId)
        {
            var filter = Builders<Employee>.Filter.Eq(employee => employee.EmployeeId, empId);
            _mongoDatabase.GetCollection<Employee>("Employee").DeleteOne(filter);
        }
    }
}
