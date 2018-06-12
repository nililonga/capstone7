using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12InClass
{
    class Person
    {    
            private string name;
            public string Name { get => name; set => name = value; }

            private string address;
            public string Address { get => address; set => address = value; }

            public Person(string name, string address)
            {
                this.Name = name;
                this.Address = address;
            }

            public string GetDomain()
            {
                //find the @
                int index = Address.IndexOf('@');
                //take the rest of the string AFTER the @ position
                return Address.Substring(index + 1);
            }

            public override string ToString()
            {
                return $"{Name} ({Address})";

            }
        
        
    }
}
