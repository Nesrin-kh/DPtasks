using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class Document : ICloneable
    {
        public string Header { get; set; }
        public string Footer { get; set; }
        public int Pages { get; set; }
        public string Text { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Footer: {Footer}");
            Console.WriteLine($"Pages: {Pages}");
            Console.WriteLine($"Text: {Text}");
        }
    }
}
