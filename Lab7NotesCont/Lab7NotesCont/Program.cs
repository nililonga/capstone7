using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7NotesCont
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an int: ");
            string input = Console.ReadLine();
            int Num = 0;

            try
            {
                Num = int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("That wasnt an integer");
                return;
            }

            catch (OverflowException e)
            {
                Console.WriteLine("that was invalid input");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("that's to big");
                return;
            }
            finally
            {
                Console.WriteLine("This code will always run");
            }
            Console.WriteLine($"The program is now ending");
        }
    }
}
