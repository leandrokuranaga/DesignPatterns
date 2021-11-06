using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pizzaria\n");
            Console.WriteLine("Informe o local (S) ou (R)");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza (M) ou (C)");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzaria =
                    PizzaSimpleFactory.CriarPizzaria(localEscolhido);

                var pizza = pizzaria.MontaPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}