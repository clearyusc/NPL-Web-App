using System;

namespace SimpleWebApp.Models
{
    public interface IPerson
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Address Address { get; set; }
        MinistryResponse Response { get; set; }
    }
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public MinistryResponse Response { get; set; }
    }
}