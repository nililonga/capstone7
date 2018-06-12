using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the counter");
            int count = 1;
            while (count <= 15)
            {

                Console.WriteLine(count);
                count++;
            }

            Console.WriteLine("good bye!");

            Console.WriteLine("welcome to the counter!");
            //for (initialize; expression; update)
            for (count = 1; count <= 15; count++) ;

            //count form 1 to 100 by 10s
            for (int i = 1000; i >= 0; i -= 10)
            {
                Console.WriteLine(i);
            }
            
            //count all the powers of 2 less than 1000000 by 2's
            for (int i = 1; i <= 1000000; i += 2)
            {
                Console.WriteLine(i);
            }
        }
            //count from 1000000000 to 1, factoring by 10 everytime
            for (int i = 1000000000; i >= 1; i += 10)
    }
}
