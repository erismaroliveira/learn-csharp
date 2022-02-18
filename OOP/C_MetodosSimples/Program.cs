using System;

namespace C_MetodosSimples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Erismar";
            p1.sobrenome = "Oliveira";
            p1.anoNascimento = 1994;

            Pessoa p2 = new Pessoa()
            {
                nome = "Isabella Victoria",
                sobrenome = "Oliveira",
                anoNascimento = 2014
            };

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }
}
