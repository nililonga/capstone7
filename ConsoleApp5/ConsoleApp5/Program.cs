using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            int numX2;
            bool success = int.TryParse(input, out numX2);
            if (success)
            {
                Console.WriteLine("doubled is" + TimesTwo(numX2) );
                Console.WriteLine("doubled again is " + TimesTwo(numX2))
            }
        }

        static int TimesTwo (int bob)
        {
            int doubled = bob * 2;
            return doubled;
        }
    }
}
