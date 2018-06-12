using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12InClass
{
    class Staff : Person
    {
        private string title;
        private double salary;
        //private DateTime hireDate;
        private string campus;
        private string v1;
        private string v2;

        public Staff(string name, string address, string v1, string v2) : base(name, address)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Staff(string s1, string s2, string title,
            double salary, string campus) : base(s1, s2)
        {
            //I have to call a superclass constructor above
            // with the keyword base
            //if I don't, there's an implicit call to the 
            //    no -argument or default constructor

            this.title = title;
            this.salary = salary;
            this.campus = campus;
        }
        public override string ToString()
        {
            return base.ToString() +  $"{title} ${salary}";

        }
    }
}
