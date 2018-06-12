using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectoriented1notes
{
    class User
    {
        static void Main(string[] args)

        {
            UserClass user1 = new UserClass("Shock G", "HelloWorld", "shock@gmail.com", 25);
            UserClass user2 = new UserClass("Chuck", "Booling", "chuck@pe.com", 33);

            Console.WriteLine(user1.GetName());
            Console.WriteLine(user1.GetAge());
            Console.WriteLine(user1.GetRegDate());


            Console.Write($"Please enterr {user1.GetName()}'s password: ");
            string pass = Console.ReadLine();
        }
    }
}
