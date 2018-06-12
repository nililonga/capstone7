using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {


            int total = 0;

            Console.WriteLine("Enter a word so we can find the vowels for you!"); ;
            string input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                //
                if (input.Contains("a"))
                {
                    total++;
                }
            }
            Console.WriteLine( (total++));

            Console.ReadLine();
        
        
        


    










        }
    }
}
