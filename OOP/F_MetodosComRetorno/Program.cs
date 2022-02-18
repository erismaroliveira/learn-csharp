using System;

namespace F_MetodosComRetorno
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            string nomeCompleto = m.MontaNome("Erismar", "Oliveira");
            double codigo = m.CodigoChar('A');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigo);

            Console.ReadKey();
        }
    }
}
