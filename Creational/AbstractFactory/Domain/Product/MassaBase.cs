using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome { get; set; }
        public ArrayList Ingredientes = new ArrayList();

        protected MassaBase(string nome, TipoMassa tipo)
        {
            TipoMassa = tipo;
            Nome = nome;
        }
    }
}
