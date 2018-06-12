using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class UsedCar : Car
    {
        private double milage;

        public double Milage { get => milage; set => milage = value; }


        public UsedCar (string make, string model, int year, double price, double milage) : base (make, model, year, price)
        {
            this.milage = milage;  
        }

        public override string ToString()
        {
            string result = base.ToString() + $" Milage: {milage}";
            return result;
        }


    }
}
