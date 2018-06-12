using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNotes52
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates an array list
            ArrayList myList = new ArrayList();
            //add information to list
            myList.Add("maggie");
            myList.Add("Jaide");
            myList.Add("Shaun");

            Console.WriteLine($"Capacity(Phys Size): {myList.Capacity}");
            Console.WriteLine($"Count(Logical Size): {myList.Count}");

            //what does this accomplish
            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }
               
                //add names
                //why are they added individually
            myList.Add("Mubin");
            myList.Add("Anamul");
            myList.Add("Adam");
            myList.Add("Jacob");
            myList.Add("bob");
            myList.Add("calleen");

            //resets a value
            myList[7] = "Nadim";
           
            //add to specific position in list
            //puts at indicated place and pushes everything else back, creating additional space if needed
            myList.Insert(2, "Justin");
            myList.Remove("Jacob");
            myList.Remove("bob");

            Console.WriteLine($"Capacity(Phys Size): {myList.Capacity}");
            Console.WriteLine($"Capacity(Logical Size): {myList.Count}");

            //check for information in index
           //Console.WriteLine("The name nadim is at" + Index)

            //?
            //why?
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            
            //why is this down here
           
        }
    }
}
