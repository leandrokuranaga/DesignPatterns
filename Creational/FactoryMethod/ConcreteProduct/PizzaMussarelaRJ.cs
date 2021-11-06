using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //concrete product
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa fina crocante Carioca";
            molho = "Molho de tomate italiano Carioca";
            ingredientes.Add("Queijo parmesão ralado");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}
