using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class CarLot
    {
        public static List<Car> DisplayList()
        {
            List < Car > Cars = new List<Car>();

            Cars.Add(new Car("ford", "fusion", 2009, 26000));
            Cars.Add(new Car("chrysler", "200", 2014, 28000));
            Cars.Add(new Car("dodge", "ram", 2008, 34000));
            Cars.Add(new UsedCar("Toyota", "Corolla", 2013, 12000, 50000));
            Cars.Add(new UsedCar("Ford", "Focus", 2006, 3000, 250000));
            Cars.Add(new UsedCar("Cadillac", "Escalade", 2011, 19000, 1200000));

            return Cars;

            
        }



    }
}
