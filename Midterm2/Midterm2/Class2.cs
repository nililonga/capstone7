using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    class Class2
    {
        answer == "2")
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
    }
}
