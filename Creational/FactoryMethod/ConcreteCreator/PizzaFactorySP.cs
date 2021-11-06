using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaRJ();
            }
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresaRJ();
            }
            else return null;
        }
    }
}
