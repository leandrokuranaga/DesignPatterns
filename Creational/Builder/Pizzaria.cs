using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizzaria
    {
        private readonly PizzaBuilder builder;

        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void MontaPizza()
        {
            builder.CriaPizza();
            builder.PreparaMassa();
            builder.IncluiIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }

    }
}
