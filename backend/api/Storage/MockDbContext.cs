using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Storage
{
    public class MockDbContext : IDbContext
    {
        public MockDbContext()
        {
            this.GenerateUsers();
        }

        public ICollection<User> Users { get; set; }
    
        private void GenerateUsers()
        {
            Users = new List<User>() {
              new User("Ceyhun", "Mavzer", "Spillegem 3/201", "9600", "BE", "Welcome Slav superstar"),
              new User("Fillip  ", "Vanhoorelbeke", "Some Street 123", "1000", "BE", "Welcome Filip"),
              new User("John", "Do", "Ergens", "1200", "US", "Welcome John"),
              new User("Foo", "Bar", "Foobarstraat 9", "9700", "BE", "Welcome Fool"),
              new User("Olly", "Thepug", "Dogheaven 420", "3131", "DG", "Welcome Good Boy"),
            };
        }
    
    }
}
