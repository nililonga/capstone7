using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Task newTask = new Task("Garbage", "not done");
            Task secondTask = new Task("Dishes", "done");

            Console.WriteLine(newTask.TaskNumber + " " + newTask.TaskName);
            Console.WriteLine(secondTask.TaskName + " " + secondTask.TaskNumber + " " + secondTask.DueDate);

            List<Task> TaskList = new List<Task>();

            bool whileBool = false;

            while (whileBool)
            {
                TaskList.Add(new Task(Console.ReadLine(),Console.ReadLine()));
            }
        }
    }
}
