using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void BuildDough()
        {
            pizza.Dough = "Thin Crust";
        }

        public void BuildSauce()
        {
            pizza.Sauce = "Tomato";
        }

        public void BuildTopping()
        {
            pizza.Topping = "Mozzarella";
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
