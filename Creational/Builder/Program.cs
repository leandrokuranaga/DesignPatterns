using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizzaria pizzaria = new(new PizzaCalabresa());
            pizzaria.MontaPizza();
            var pizza1 = pizzaria.GetPizza();
            pizza1.PizzaConteudo();

            pizzaria = new (new PizzaMussarela());
            pizzaria.MontaPizza();
            var pizza2 = pizzaria.GetPizza();
            pizza2.PizzaConteudo();

            Console.ReadKey();
        }
    }
}