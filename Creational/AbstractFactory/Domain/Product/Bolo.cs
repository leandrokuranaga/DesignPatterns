using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
        {

        }
    }
}
