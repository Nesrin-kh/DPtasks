using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }

        public void ShowPizza()
        {
            Console.WriteLine("Dough: " + Dough);
            Console.WriteLine("Sauce: " + Sauce);
            Console.WriteLine("Topping: " + Topping);
        }
    }
}
