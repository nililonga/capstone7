using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7Validate
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string IsPhoneNumber;
            string IsEmail;
            string IsName;
            string IsDate;

            Console.WriteLine("Please enter a valid name: ");
            IsName = (Console.ReadLine());

            bool ValidName = Regex.IsMatch(IsName, "[A-Z]a*[a-z]{1,30}");
            Console.WriteLine(ValidName);

            Console.Write("Please enter a valid Phone Number (123-123-4567):  ");
            IsPhoneNumber = (Console.ReadLine());

            bool ValidPhoneNumber = Regex.IsMatch(IsPhoneNumber, "\\d{3}[-]\\d{3}[-]+\\d{4}");
            Console.WriteLine(ValidPhoneNumber);

            Console.WriteLine("Please enter a valid email (yourname@whoever.com)");
            IsEmail = (Console.ReadLine());

            bool ValidEmail = Regex.IsMatch(IsEmail, "\\w.{5,30}@\\w{5,10}.\\w{2,3}");
            Console.WriteLine(ValidEmail);

            Console.WriteLine("Please enter a valid date (dd/mm/yyyy)");
            IsDate = (Console.ReadLine());

            bool ValidDate = Regex.IsMatch(IsDate, "\\d[0-31]\\/\\d[1-12]\\/\\d[1900-2018]" );
            Console.WriteLine(ValidDate);



    
        }
    }
}
