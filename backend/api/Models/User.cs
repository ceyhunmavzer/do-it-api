namespace api.Models
{
    public class User
    {
        public User()
        {

        }

        public User(string name, string lastName, string address, string postalCode, string country, string personalGreeting)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            PostalCode = postalCode;
            Country = country;
            PersonalGreeting = personalGreeting;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PersonalGreeting { get; set; }

    }
}