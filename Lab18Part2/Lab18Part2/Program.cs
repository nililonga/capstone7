using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array[0] = 1;
            array[1] = 1;
            array[2] = 1;
            array[3] = 2;
            array[4] = 1;
            array[5] = 2;
            array[6] = 1;
            array[7] = 1;
            array[8] = 2;
            array[9] = 3;

            /*  int count = 0;
              foreach (int value in array)
                  if (value == 1) ++count;
              Console.WriteLine(count);*/

            int[] result = Array.FindAll(array, delegate (int i) { return i == 1; });
            Console.WriteLine(result.Length); // 6

            //use counter
        }
    }
}
