using System;

namespace D_MetodosComParametros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Apresentar("Anna Eloah", 4);
            m.Somar(100, 50);

            Console.ReadKey();
        }
    }
}
