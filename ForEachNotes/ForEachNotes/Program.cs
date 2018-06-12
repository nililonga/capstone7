using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] dblArray = { 14.23, 14.54, 15.20, 16.24 };

            foreach (double item in dblArray)
            {
                Console.WriteLine(item);
            }
            //using string to show string indexes
            string data = "hello";
            foreach (char letters in data)
            {
                Console.WriteLine(letters);
            }
            //new array ex

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };


            foreach (int number in intArray)
            {
                Console.WriteLine(number + 10);
            }
           
            //string array

            string[] wordArray = { "hello", "from", "grand", "circus" };
            foreach (string words in wordArray)
            {
                Console.WriteLine(words);
            }
        }
    }
}
