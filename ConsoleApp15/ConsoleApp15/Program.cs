using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string Radius;

            Console.Write("enter the radius:  ");
            Radius = (Console.ReadLine());

            bool ValidRadius = Regex.IsMatch(Radius, "\\d{1,5000}.\\d{1,5000}");
            Console.WriteLine(ValidRadius);
        }
    }
}
