using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person("Peter Guenther",
                "peter@grandcircus.co");
            people.Add(person1);

            people.Add(new Person("Jacob Snover",
                "jacob@gmail.com"));
            List<Student> students = new List<Student>();

            /*
            Console.Write("Please enter the name: ");
            string s1 = Console.ReadLine();
            Console.Write("Please enter the email address: ");
            string s2 = Console.ReadLine();

            Person person2 = new Person(s1, s2);
            */

            Console.WriteLine("Traditional for:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"Hello {people[i]}");
                string domain = people[i].GetDomain();
                Console.WriteLine($"Domain: {domain}");
            }

            //Staff s1 = new Staff();
            Staff staff1 = new Staff("Kim Drisoll", "kim@grandcircus.co", "Director of Learning", 1500000, "Detroit");
            Console.WriteLine(staff1);
            people.Add(staff1);
            Staff staff2 = new Staff("Kim Drisoll", "kim@grandcircus.co", "Director of Learning", 100000,  "Detroit");
            Console.WriteLine(staff2);

            Student student1 = new Student("Noelle I", "noelle@gmail.com", "C#", "Q2 2018", 100000);
            Console.WriteLine(student1);
            people.Add(student1);

            
            
            Console.WriteLine("\nForeach:");
            foreach (Person p in people)
            {
                Console.WriteLine(p.GetType());
                Console.WriteLine($"Hello {p}");
                Console.WriteLine($"Domain: {p.GetDomain()}");
            }

            foreach (Student s in students)
            {
                Console.WriteLine($"Hello {s}");
            }
        }
    }
}
