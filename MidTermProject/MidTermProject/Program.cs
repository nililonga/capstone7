using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<Car> Display = CarLot.DisplayList();

            Car AllCars = new Car();

            //menu
            Console.WriteLine("Select an action:");
            Console.WriteLine("1. List an item");
            Console.WriteLine("2. Add a car");
            Console.WriteLine("3. Remove a car");
            Console.WriteLine("4. Look up a car");
            Console.WriteLine("5. Replace a car");
            string menuanswer = Console.ReadLine();

            //display list
            int Counter = 0;
            string answer22;

            if (menuanswer == "1")
            {
                foreach (Car c in Display)
                {
                    Counter++;
                    Console.WriteLine(Counter + ". " + c.ToString());
                }
                Console.WriteLine("would you like to go back to main menu? (Y/N)");
                answer22 = Console.ReadLine();
            }                    
            else if (menuanswer == "2")
            {
                Console.WriteLine("are you adding a new or used vehicle? (N/U)");
                string answer88 = Console.ReadLine().ToUpper();
                if (answer88 == "N")
                {
                    Console.WriteLine("enter make: ");
                    string makei = Console.ReadLine();
                    Console.WriteLine("enter model: ");
                    string modeli = Console.ReadLine();
                    Console.WriteLine("enter year: ");
                    int yeari = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter price: ");
                    double pricei = Convert.ToDouble(Console.ReadLine());
                    Display.Add(new Car(makei, modeli, yeari, pricei));
                    foreach (Car c in Display)
                    {
                        Counter++;
                        Console.WriteLine(Counter + ". " + c.ToString());
                    }
                }
                if (answer88 == "U")
                {
                    Console.WriteLine("enter make: ");
                    string makei = Console.ReadLine();
                    Console.WriteLine("enter model: ");
                    string modeli = Console.ReadLine();
                    Console.WriteLine("enter year: ");
                    int yeari = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter price: ");
                    double pricei = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter milage: ");
                    double milagei = Convert.ToDouble(Console.ReadLine());
                    Display.Add(new UsedCar(makei, modeli, yeari, pricei, milagei));
                    foreach (Car c in Display)
                    {
                        Counter++;
                        Console.WriteLine(Counter + ". " + c.ToString());
                    }
                }
            }
            else if (menuanswer == "3")
            {
                string answer12 = "";
                do
                {
                    Console.WriteLine("which item would you like to remove?");
                    answer = Console.ReadLine();
                    Display.RemoveAt(Convert.ToInt32(answer) - 1);

                    foreach (Car c in Display)
                    {
                        Counter++;
                        Console.WriteLine(Counter + ". " + c.ToString());
                    }
                    Console.WriteLine("would you like to remove another item?");
                    answer12 = Console.ReadLine().ToUpper();
                } while (answer12 == "Y");
                
            }
            else if (menuanswer == "4")
            {
                string answer40 = "";
                do
                {
                    //prompt user to select cars
                    Console.WriteLine($"Select which car you would like to view (1-{Display.Count}): ");
                    answer = Console.ReadLine();
                    Console.WriteLine(Display[Convert.ToInt32(answer) - 1].ToString());
                    Console.WriteLine("Would you like to purchase? (Y/N)");
                    string answer2 = Console.ReadLine().ToUpper();
                    if (answer2 == "Y")
                    {
                        Display.RemoveAt(Convert.ToInt32(answer) - 1);
                        foreach (Car c in Display)
                        {
                            Counter++;
                            Console.WriteLine(Counter + ". " + c.ToString());
                        }
                    }
                    Console.WriteLine("Would you like to purchase another vehicle?");
                    answer40 = Console.ReadLine();
                } while (answer40 == "Y");

            }
            else if (menuanswer == "5")
            {   string answer50 = "";
                do
                {
                    Console.WriteLine($"which car would you like to replace (1-{Display.Count}): ");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.WriteLine("are you adding a new or used vehicle? (N/U)");
                    string answer88 = Console.ReadLine().ToUpper();
                    if (answer88 == "N")
                    {
                        Console.WriteLine("enter make: ");
                        string makei = Console.ReadLine();
                        Console.WriteLine("enter model: ");
                        string modeli = Console.ReadLine();
                        Console.WriteLine("enter year: ");
                        int yeari = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter price: ");
                        double pricei = Convert.ToDouble(Console.ReadLine());
                        Display.RemoveAt(index);
                        Display.Insert(index, new Car(makei, modeli, yeari, pricei));
                        foreach (Car c in Display)
                        {
                            Counter++;
                            Console.WriteLine(Counter + ". " + c.ToString());
                        }
                    }
                    if (answer88 == "U")
                    {
                        Console.WriteLine("enter make: ");
                        string makei = Console.ReadLine();
                        Console.WriteLine("enter model: ");
                        string modeli = Console.ReadLine();
                        Console.WriteLine("enter year: ");
                        int yeari = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter price: ");
                        double pricei = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter milage: ");
                        double milagei = Convert.ToDouble(Console.ReadLine());
                        Display.RemoveAt(index);
                        Display.Insert(index, new UsedCar(makei, modeli, yeari, pricei, milagei));
                    }
                    Console.WriteLine("would you like to replace another vehicle?");
                    answer50 = Console.ReadLine().ToUpper();
                } while (answer50 == "Y");
            }
        }
    }
}

