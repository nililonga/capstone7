using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12InClass
{
    class Student : Person
    {
        private string language;
        private string quarter;
        private double tuition;
        public string Language { get => language; set => language = value; }
        public string Quarter { get => quarter; set => quarter = value; }
        public double Tuition { get => tuition; set => tuition = value; }


        public Student(string name, string address, string language, string quarter, double tuition) : base(name, address)
        {
            this.Language = language;
            this.Quarter = quarter;
            this.Tuition = tuition;
        }
        public override string ToString()
        {
            return base.ToString() + $" {language} {quarter} ${tuition}";
        }
    }
}
