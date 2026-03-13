using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    class ReadyForReviewState : ITaskState
    {
        public void Handle(TaskContext task)
        {
            Console.WriteLine("Task is ready for review...");

            task.SetState(new DoneState());
        }
    }
}
