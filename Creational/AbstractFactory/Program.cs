using AbstractFactory.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactory // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
            var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

            var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
            var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

            var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
            var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabresa);

            ExibeDetalhes(bolo1);
            ExibeDetalhes(bolo2);
            ExibeDetalhes(pizza1);
            ExibeDetalhes(pizza2);

            Console.ReadLine();

            static void ExibeDetalhes(MassaBase massaBase)
            {
                Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
                Console.WriteLine(massaBase.Nome);
                Console.WriteLine(massaBase.Ingredientes[0].ToString());
                Console.WriteLine("\n");
            }

        }
    }
}