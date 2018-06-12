using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");

            string[] Names = { "Allen", "Barry", "Chris", "Danny", "Elle", "Frank", "George", "Hana", "Ijania", "Jimmy", "Kim", "Larry", "Mary", "Noelle", "Odessa", "Perry", "Quincy", "Roger", "Stacy", "Toni" };
            string[] Food = { "Apples", "Bread", "Cherries", "Donuts", "Eggplant", "Fish", "Gravy", "Hummas", "Icing", "Jackfruit", "Kiwi", "Lamb", "Macaroni", "Nuts", "Oatmeal", "Peaches", "Quinoa", "Rice", "Sandwiches", "Tomatos" };
            string[] HomeTown = { "Abbot, TX", "Bolton, MI", "Chattahoochee, TN", "Daisy, MA", "Eastfield, NY", "Fairmount, WA", "Guilford, UK, ", "Hampdem, MA", "Islip, NY", "Jabez, KY", "Knoxville, GA", "Lents, OR", "Misty, GA", "Nabb, IL", "Oakhill, FL", "Philips, FL", "Q", "Ruby, AK", "South End, MA", "The Bronx, NY" };






            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-20):");
            string input = Console.ReadLine();
            int index;
            int.TryParse(input, out index);

            //This allow the names to be diplayed 1-20
            index--;

            while (true)
            {
                if (index >= 0 && index < Names.Length)
                {

                    Console.WriteLine($"Student {index + 1} is {Names[index]}. What would you like tho know about {Names[index]}? (enter hometown or favorite food)");


                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20)");
                }


                string input2 = "hometown";
                input2 = Console.ReadLine();
                string input3 = "food";
                input3 = Console.ReadLine();

                if (input2 == "hometown")
                {
                    Console.WriteLine($"{Names[index]} is from {HomeTown[index]}. Would you like to know more about {Names[index]}? (enter hometown or food)");
                }
                else if (input2 == "food")
                {
                    Console.WriteLine($"{Names[index]} likes {Food[index]}. Would you like to know more about {Names[index]}? enter yes or no):");
                }
                {
                    string answer = "yes";
                    answer = Console.ReadLine();
                    {
                        if (answer != "yes") ;
                    }
                    break;
                
                }
    }
}
