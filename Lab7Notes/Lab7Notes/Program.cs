using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare
            int score;
            
            

            //conditionals 
            Console.Write("How many points possible?");
            string input = Console.ReadLine();

            //turn string into int
            int points = 100;
            int.TryParse(input, out score);

            if (points <= 0 || (double)score / points > 1)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                double percent = score / points;

                //output
                Console.WriteLine($"Your percent is: {percent}");
            }

            
        }
    }
}
