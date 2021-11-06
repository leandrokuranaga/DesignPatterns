using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public override void PreparaMassa()
        {
            pizza.tipoMassa = TipoMassa.Grossa;
            pizza.tipoBorda = TipoBorda.Reacheada;
            pizza.tamanho = Tamanho.Grande;
        }
        public override void IncluiIngredientes()
        {
            pizza.ingredientes = new List<string> { "Mussarela",
                "Molho de tomate", "Orégano" };
        }
    }
}
