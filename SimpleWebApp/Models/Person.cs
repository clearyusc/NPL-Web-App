namespace SimpleWebApp.Models
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Address Address { get; set; }
        MinistryResponse Response { get; set; }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public MinistryResponse Response { get; set; }
    }
}