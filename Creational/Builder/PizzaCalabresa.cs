using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public sealed class PizzaCalabresa : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            pizza.tipoMassa = TipoMassa.Grossa;
            pizza.tipoBorda = TipoBorda.Normal;
            pizza.tamanho = Tamanho.Grande;
        }
        public override void IncluiIngredientes()
        {
            pizza.ingredientes = new List<string> { "Calabresa em fatias",
                "Molho de tomate" };
        }
    }
}
