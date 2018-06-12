using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {//menu list
            Task task1 = new Task("List Tasks");
            Task task2 = new Task("Add Task");
            Task task3 = new Task("Delete Task");
            Task task4 = new Task("Mark Task complete");
            List<Task> menu = new List<Task>();
            menu.Add(task1);
            menu.Add(task2);
            menu.Add(task3);
            menu.Add(task4);

            //task list
            Task taskA = new Task("Laundry");
            Task taskB = new Task("Dishes");
            Task taskC = new Task("Garbage");
            Task taskD = new Task("mow lawn");
            List<Task> chores = new List<Task>();
            chores.Add(taskA);
            chores.Add(taskB);
            chores.Add(taskC);
            chores.Add(taskD);

            Console.WriteLine("Welcome to task list");

            foreach (Task a in menu)
            {
                Console.WriteLine(a.TaskName);
            }
            Console.WriteLine("Choose an item from the menu by entering item number");
            string answer = Console.ReadLine();
            int answer2;
            if (answer == "1")
            {
                foreach (Task b in chores)
                {
                    Console.WriteLine(b.TaskName);
                }
            }
            else if (answer == "2")
            {
                Console.WriteLine("Enter new task");
                answer2 = chores.Add(new Task Convert.ToInt32((Console.ReadLine());
            }
            else if (answer == "3")
            {
                Console.WriteLine("Enter Task Number");
                int answer3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Are you sure you would like to delete task {answer3} (Y/N)?");
                int answer4 = Convert.ToInt32(Console.ReadLine());
                int Y = 0;
                if (answer4 == Y)
                {
                    chores.RemoveAt(answer3);
                }
                else
                {
                    return;
                }
            }
            else if (answer == "4")
            {
                Console.WriteLine("Which task would you like to mark complete?");
                int answer5 = Convert.ToInt32(Console.ReadLine());
            }
    }
}
