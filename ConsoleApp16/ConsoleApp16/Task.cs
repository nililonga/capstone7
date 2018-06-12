using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Task
    {
        public string TaskName { get; set; }

        public DateTime DueDate { get; set; }

        public Task(string taskName)
        {
            TaskName = taskName;
            DueDate = DateTime.Now.AddDays(14);
        }
    }
}
