using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask1
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
        Pizza GetPizza();
    }
}
