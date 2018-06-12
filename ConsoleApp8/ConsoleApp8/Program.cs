using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        { //welcome user
            Console.WriteLine("Hello");
            Console.WriteLine();

            //begin do while loop
            string answer;

            do
            {x               //prompt user to enter number
                Console.WriteLine("Please enter a number to begin");

                //declare variable
                //convert input to variable
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //find range
                for (int y = 1; y <= x; y++)

                {
                    //print range of numbers
                    Console.Write(y + "\t");

                    //print range of numbers squared
                    Console.Write(y * y + "\t");

                    //print range of numbers cubed
                    Console.WriteLine(y * y * y + "\t");
                }
                //finish while loop
                Console.WriteLine("Would you like to continue? (yes/no)");
                answer = Console.ReadLine();
            }
            while (answer == "yes");

        }
    }
}
