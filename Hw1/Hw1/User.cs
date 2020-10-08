using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public User(string FirstName, string LastName, string Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;

            ID = IDGenerator.ID;
        }

        public void GetMessage(Message message)
        {
            Console.WriteLine($"Title: {message.Title}\nContent: {message.Content}");
        }
    }
}
