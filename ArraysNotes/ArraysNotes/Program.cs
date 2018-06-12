using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNotes
{
    class Program

    {
        //confused
        private const int COUNT = 5;
        static void Main(string[] args)
        {
            //1. declare total and set to zero
            int total = 0;
            //2. starts at zero and has user enter score for 1-5, increasing by 1's(loop number)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("please enter score {i + 1}: ");
                
                //take input to string
                string input = Console.ReadLine();

                //declare then initialize
                int num = 0;
                //I do not understand this
                int.TryParse(input, out num);
                
                //3. add the next number
                total += num;
            }
            //4. output the total
            Console.WriteLine($"The total is {total}");

            //5. for average divide by # of number/confused
            double average = (double)total / COUNT;
            Console.WriteLine($"The average is {average}");
        }
    }
}
