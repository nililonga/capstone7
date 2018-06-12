using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            Console.WriteLine("enter a number: ");
            answer = int.Parse(Console.ReadLine()); ;

            int[] array = { 1, 2, 3, 5, 8, 10, 15, 23 };
            int arraySum = array.Sum();

            while (answer <= arraySum)
            {
                Console.WriteLine("True");
                break;
            }

            if (answer >= arraySum)
            {
                Console.WriteLine("False");
                
            }
            

        }
    }
}
