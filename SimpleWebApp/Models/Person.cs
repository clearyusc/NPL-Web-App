namespace SimpleWebApp.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public MinistryResponse Response { get; set; }
    }
}