using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        public static string GetDummyData()
        {
            return @"
                [{'FirstName': 'David', 'LastName': 'Maisuradze', 'Address': 'Tsereteli'}, 
                    {'FirstName': 'John', 'LastName': 'Doe', 'Address': '123 Maple Street'}, 
                    {'FirstName': 'Jane', 'LastName': 'Roe', 'Address': 'Beverly Hills, CA'}]
            ";
        }
        static void Main(string[] args)
        {
            IList<IDictionary<string, string>> userDict = JsonConvert.DeserializeObject<IList<IDictionary<string, string>>>(GetDummyData());
            Console.WriteLine("Select User: ");
            for (int i = 0; i < userDict.Count; i++)
            {
                Console.WriteLine($"{i} - {userDict[i]["FirstName"]} {userDict[i]["LastName"]}");
            }
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                string title, content;
                Console.Write("Message Title: ");
                title = Console.ReadLine();
                Console.Write("Message Content: ");
                content = Console.ReadLine();
                User user = new User(userDict[index]["FirstName"], userDict[index]["LastName"], userDict[index]["Address"]);
                Post.Instance.SendMessage(user, new Message(title, content));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
