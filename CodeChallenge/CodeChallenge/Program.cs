using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            ArrayList Names = new ArrayList();
            //declares success as true
            bool success = true;

            while (success)
            {
                //user input
                Console.Write("Please enter a name, or enter 'quit': ");
                //take user input and make string
                string input = Console.ReadLine();
                //takes user input and adds to arraylist
                Names.Add(input);
                
                //remove quit as name
                Names.Remove("quit");


                //if user quits this outputs capacity and count of arraylist
                if (input.ToLower() == "quit")
                {

                    Console.WriteLine($"Capacity(Phys Size): {Names.Capacity}");
                    Console.WriteLine($"Count(Logical Size): {Names.Count}");
                    foreach (string s in Names)
                    {
                        Console.WriteLine(s);
                    }
                    success = false;
                }
                //if user does not quit this allows them to continue entering names
                else
                {
                    success = true;
                }

            }


            
        }
    }
}
