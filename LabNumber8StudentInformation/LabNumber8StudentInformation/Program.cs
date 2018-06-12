using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student information bank");
            //make array
            string[] names = { "abby", "bobby", "charlie", "danny", "eddie" };
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index;

            //
            for (int s = 0; s < names.Length; s++)
            {
                Console.WriteLine("which student would you like to know about (1-5)?");
                string input = (Console.ReadLine());
                

                if (input >= 0 && input < names.Length)
                {
                      Console.WriteLine($"{names[index]} costs ${numbers[index]}");
                }
            }
        }
    }
}
