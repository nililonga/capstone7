using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
             

            Console.WriteLine("enter a number between 1-50: ");
            int input = (Convert.ToInt32(Console.ReadLine()));
            
            while (true)
            {
                if (input > 1 && input < 50)
                  
                {
                    int x = rnd.Next(1, 50);
                    if (x - input >= 10)
                    {
                        Console.WriteLine("Your number was WAY too small, try again");
                        input = (Convert.ToInt32(Console.ReadLine()));
                    }
                    if (x - input > 0 && x - input < 10)
                    {
                        Console.WriteLine("Your number was too large, try again");
                        input = (Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (x - input <= -10)
                    {
                        Console.WriteLine("that number was WAY too large, try again!");
                        input = (Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (x - input < x)
                    {
                        Console.WriteLine("that number was too low, try again!");
                        input = (Convert.ToInt32(Console.ReadLine()));
                    }
                    else if (input == x)
                    {
                        Console.WriteLine("you got it!");
                        Console.WriteLine($"The numbers {x} and {input} are the same!");
                        Environment.Exit(0);
                    }
                }
            }   

    
        }
    }
}
