using System;

namespace L_ClassesEstaticas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Matematica.taxa = 20;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);

            Console.ReadKey();
        }
    }
}
