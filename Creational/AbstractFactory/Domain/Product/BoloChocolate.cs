using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}
