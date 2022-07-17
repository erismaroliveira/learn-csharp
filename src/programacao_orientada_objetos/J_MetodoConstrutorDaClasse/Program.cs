using System;

namespace J_MetodoConstrutorDaClasse
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

            Console.ReadKey();
        }
    }
}
