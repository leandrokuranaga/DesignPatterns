using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {

        }
    }
}
