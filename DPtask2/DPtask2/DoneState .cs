using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    class DoneState : ITaskState
    {
        public void Handle(TaskContext task)
        {
            Console.WriteLine("Task is completed.");
        }
    }
}
