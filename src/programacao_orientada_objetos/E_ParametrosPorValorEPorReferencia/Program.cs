using System;

namespace E_ParametrosPorValorEPorReferencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            int valor1 = 100;
            int valor2 = 100;

            m.Aumentar(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);

            Console.ReadKey();
        }
    }
}
