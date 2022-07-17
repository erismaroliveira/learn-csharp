using System;

namespace G_SobrecargaDeMetodos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Cumprimentar();
            m.Cumprimentar("Erismar");
            m.Cumprimentar("Erismar", 28);

            Console.WriteLine(m.Comparar(25, 5 * 5));

            Console.ReadKey();
        }
    }
}
