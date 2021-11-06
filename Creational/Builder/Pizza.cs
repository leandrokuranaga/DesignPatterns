using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public TipoMassa tipoMassa;
        public Tamanho tamanho;
        public TipoBorda tipoBorda;
        public List<string> ingredientes;

        public Pizza(TipoMassa tipoMassa, Tamanho tamanho, TipoBorda tipoBorda, List<string> ingredientes)
        {
            this.tipoMassa = tipoMassa;
            this.tamanho = tamanho;
            this.tipoBorda = tipoBorda;
            this.ingredientes = ingredientes;
        }
        public Pizza()
        {

        }
        public void PizzaConteudo()
        {
            Console.WriteLine($"Pizza com massa : {tipoMassa}");
            Console.WriteLine($"Tamanho : {tamanho}");
            Console.WriteLine($"Tipo Borda : {tipoBorda}");
            Console.WriteLine("Ingredientes");
            foreach(var item in ingredientes)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
