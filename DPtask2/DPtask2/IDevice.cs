using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    internal interface IDevice
    {

        void IncreaseVolume();
        void DecreaseVolume();
        void Mute();
    }

    class TV : IDevice
    {
        public void IncreaseVolume()
        {
            Console.WriteLine("TV Volume Increased");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("TV Volume Decreased");
        }

        public void Mute()
        {
            Console.WriteLine("TV Muted");
        }
    }

    class Speaker : IDevice
    {
        public void IncreaseVolume()
        {
            Console.WriteLine("Speaker Volume Increased");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Speaker Volume Decreased");
        }

        public void Mute()
        {
            Console.WriteLine("Speaker does not support mute");
        }
    }

    abstract class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void Increase();
        public abstract void Decrease();
    }

    class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device) { }

        public override void Increase()
        {
            device.IncreaseVolume();
        }

        public override void Decrease()
        {
            device.DecreaseVolume();
        }
    }

    class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public override void Increase()
        {
            device.IncreaseVolume();
        }

        public override void Decrease()
        {
            device.DecreaseVolume();
        }

        public void Mute()
        {
            device.Mute();
        }
    }
}
