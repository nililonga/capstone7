using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalmethodbreakoutexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number");
            string input = Console.ReadLine();

            int selection = Validate(input);

            Console.WriteLine(selection);


        }
        public static int Validate(string input)
        {
            int number;
            while(int.TryParse(input, out number) == false) //OR while (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input");
            }

            return number;
        }
    }

}
