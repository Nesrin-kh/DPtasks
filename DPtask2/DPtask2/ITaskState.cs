using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
     interface ITaskState
    {
        void Handle(TaskContext task);
    }
}
