using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = "hello class.";
            //call method
            string Response = PrintMessage(Message);

            //new example
            int x = 15;
            int y = 25;
                        //this is an int
            int sum =   AddNumbers(x, y);
            Console.WriteLine(sum);

            //third example
            string message2 = "hello again";
            bool empty = IsEmpty(message2);

            if (IsEmpty(message2)== false) //Or if (!IsEmpty(message2))
            {
                Console.WriteLine(message2);
            }

        }
        //1
        //it would say public static void if there were no return type coming from the method
        //if you have a non void return type you must have return keyword
        public static string PrintMessage (string message)
        {
            Console.WriteLine(message);
            return message;
        }
        //newexmple step2
        public static int AddNumbers(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }
        //third example
        public static bool IsEmpty(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string ReturnString(string data)
        {
            return data;
        }
        public static string ToUpper(string mike)
        {
            return mike.ToUpper();
        }
    }
}
