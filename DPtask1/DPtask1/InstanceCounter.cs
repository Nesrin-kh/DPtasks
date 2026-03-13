using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class InstanceCounter
    {
        private static InstanceCounter instance;

        public int Count { get; private set; }

        private InstanceCounter()
        {
            Count = 0;
        }

        public static InstanceCounter GetInstance()
        {
            if (instance == null)
            {
                instance = new InstanceCounter();
            }

            return instance;
        }

        public void Increment()
        {
            Count++;
        }
    }
}
