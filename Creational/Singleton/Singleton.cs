using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numeroDeInstancias = 0;

        public Singleton()
        {
            Console.WriteLine("Instanciando dentro de construtor privado");
            numeroDeInstancias++;
            Console.WriteLine($"Número de instancias = {numeroDeInstancias}\n");
        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    Console.WriteLine("Criando primeira instancia");
                    instance = new Singleton(); 
                }
                return instance;
            }
        }

    }
}
