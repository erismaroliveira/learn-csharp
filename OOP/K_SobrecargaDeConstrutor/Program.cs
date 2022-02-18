using System;

namespace K_SobrecargaDeConstrutor
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa();

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);

            Console.WriteLine();

            p1.nome = "Lucas";
            Console.WriteLine(p1.nome);

            Console.WriteLine();

            Pessoa p2 = new Pessoa("Erismar", "Oliveira", 1994);

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade);

            Console.WriteLine();

            Pessoa p3 = new Pessoa("João", "Silva");

            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.sobrenome);
            Console.WriteLine(p3.anoNascimento);
            Console.WriteLine(p3.idade);

            Console.ReadKey();
        }
    }
}
