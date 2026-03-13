using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    class InProgressState : ITaskState
    {
        public void Handle(TaskContext task)
        {
            Console.WriteLine("Task is in progress...");

            task.SetState(new ReadyForReviewState());
        }
    }
}
