namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton");
            Console.WriteLine("Instancia 1");

            Singleton s1 = Singleton.Instance;
            
            Console.WriteLine("Inst 2");
            Singleton s2 = Singleton.Instance;

            if(s1 == s2)
            {
                Console.WriteLine("Existem somente uma instancia (s1 == s2)");
            }
            else
            {
                Console.WriteLine("Existem instancias diferentes (s1 e s2)");
            }
            Console.Read();
        }
    }
}