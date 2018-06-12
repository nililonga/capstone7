using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome and prompt user
            Console.WriteLine("Welcome to The Table of Powers!");
            Console.WriteLine();

            //declare variable
            int number;
            bool success;

            //start do while loop before user enters number
            do
            {
                Console.WriteLine("Please enter a number, or quit to exit");
                string input = Console.ReadLine();


                
                //make program quit early
                input = input.ToUpper();
                if (input == "quit")
                {
                    Console.WriteLine("See you soon!");
                    return;
                }

                //determine if user input is valid
                success = int.TryParse(input, out number);
                if (!success)
                {
                    Console.WriteLine("That ain't no number fam");
                }

                
          
            { }
        }
    }
}
