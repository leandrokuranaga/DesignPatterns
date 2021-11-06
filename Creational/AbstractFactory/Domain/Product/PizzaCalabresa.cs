using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base("Pizza Calabresa", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabresa em cubos e tomates em cubos");
        }
    }
}
