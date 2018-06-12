using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {
           int evenNum = GetEven();
            Console.WriteLine(evenNum + " is an even number.");
        }
        static int GetEven ()
        {
            while (true)
            {
                Console.WriteLine("Please enter an even number");
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int num);
                if (success)
                {
                    if (num % 2 == 0)
                    {
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("That wasn't an int");
                    }
                }

            }
        }
    }
}

