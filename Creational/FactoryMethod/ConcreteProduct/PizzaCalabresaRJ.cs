using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabresa Carioca com cebola";
            massa = "Massa tradicional Carioca";
            molho = "Molho de tomate italiano Carioca";
            ingredientes.Add("Fatias de calabresa especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
