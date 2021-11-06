using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public void CriaPizza()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
        public abstract void PreparaMassa();
        public abstract void IncluiIngredientes();
    }
}
