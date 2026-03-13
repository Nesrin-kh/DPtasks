using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    internal class TaskContext
    {
        private ITaskState state;

        public TaskContext(ITaskState state)
        {
            this.state = state;
        }

        public void SetState(ITaskState state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
