using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2Notes
{
    class Task
    {
        public string TaskName { get; set; }

        public string TaskNumber { get; set; }
        
        public DateTime DueDate { get; set; }

        public Task(string taskName, string taskNumber)
        {
            TaskNumber = taskNumber;
            TaskName = taskName;
            DueDate = DateTime.Now.AddDays(14);
        }

    }
}
