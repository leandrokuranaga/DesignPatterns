using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza Mussarela", TipoMassa.Pizza)
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}
