using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
