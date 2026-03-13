using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public class PizzaDirector
    {
        public Pizza MakePizza(IPizzaBuilder builder)
        {
            builder.BuildDough();
            builder.BuildSauce();
            builder.BuildTopping();

            return builder.GetPizza();
        }
    }
}
